using Principle.Common.Constants;
using Principle.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Principle.Common.Utilities
{
    public static class StringOperationUtility
    {
        public static bool Compare(string source, string target)
        {
            return source.Equals(target, StringComparison.OrdinalIgnoreCase);
        }

        public static bool Contains(string source, string target)
        {
            return source.Contains(target, StringComparison.OrdinalIgnoreCase);
        }

        public static bool StringToStringCompare(string source, string target, bool isZeroDistance, out Priority priority)
        {
            var isPresent = true;
            var isContains = true;
            priority = Priority.P3;

            var sNumber = -1;
            if (int.TryParse(source, out sNumber))
            {
                var tNumber = -1;
                if (int.TryParse(target, out tNumber))
                {
                    priority = Priority.P1;
                    return (sNumber == tNumber);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                var tNumber = -1;
                if (int.TryParse(target, out tNumber))
                {
                    return false;
                }
            }

            if (!source.Equals(target, StringComparison.OrdinalIgnoreCase))
            {
                var sources = source.SplitString();
                var isSourceContainsMultipleWords = sources.Count() > 1;

                var diff = Math.Abs(source.Length - target.Length);
                var dist = LevenshteinDistance.Compute(source, target);
                if (dist > 8)
                {
                    return false;
                }
                if (source.Length <= 1)
                {
                    return isPresent;
                }
                isContains = (target.StartsWith(source, StringComparison.OrdinalIgnoreCase) && diff <= 6);
                if (source.Length > 1 && source.Length <= 6)
                {
                    if (dist == 1 || isContains)
                    {
                        priority = Priority.P2;
                    }
                    else if (dist == 2)
                    {
                        priority = Priority.P3;
                    }
                    else
                    {
                        isPresent = false;
                    }
                }
                else
                {
                    if (dist == 1 || isContains) // || (Math.Abs(source.Length - dist) > (source.Length / 2))
                    {
                        priority = Priority.P2;
                    }
                    else if (dist == 2)
                    {
                        priority = Priority.P3;
                    }
                    else if (dist == 3)
                    {
                        priority = Priority.P4;
                    }
                    else if (dist == 4)
                    {
                        priority = Priority.P5;
                    }
                    else
                    {
                        isPresent = false;
                    }
                }

                if (((!isSourceContainsMultipleWords && dist > 2) || isZeroDistance) && !isContains)
                {
                    isPresent = false;
                }
            }
            else
            {
                priority = Priority.P1;
            }
            return isPresent;
        }

        public static bool WordsToWordsCompare(string source, string target, bool isMinDistance, out Priority priority, out int distance)
        {
            priority = Priority.P3;
            distance = LevenshteinDistance.Compute(source, target);

            if (source.Equals(target, StringComparison.OrdinalIgnoreCase))
            {
                priority = Priority.P1;
                return true;
            }

            if (distance > 10)
            {
                return false;
            }

            var targets = target.SplitString();
            var sources = source.SplitString();
            var difference = Math.Abs(sources.Count() - targets.Count());
            if (difference > 2)
            {
                return false;
            }

            var isSourceContainsSpecialCharacter = sources.Count() > 1;
            var isTargetContainsSpecialCharacter = targets.Count() > 1;

            if (isSourceContainsSpecialCharacter && isTargetContainsSpecialCharacter)
            {
                var commonTerms = targets.TraverseIntersect(sources, StringComparer.OrdinalIgnoreCase).ToList();
                var matchCount = commonTerms.Count;
                var exceptTargetTerms = targets.Except(commonTerms, StringComparer.OrdinalIgnoreCase).ToArray(); //.Select(x=>new WildCompareModel { Name = x }).ToArray();
                var exceptSourceTerms = sources.Except(commonTerms, StringComparer.OrdinalIgnoreCase).ToArray();

                //var targetHashSet = new HashSet<WildCompareModel>(exceptTargetTerms);

                var isExact = true;
                if (exceptTargetTerms.Count() > 0)
                {
                    foreach (var itemSource in exceptSourceTerms)
                    {
                        var isMatch = (itemSource.Length > 2 && CompareSourceWithTargets(itemSource, exceptTargetTerms, out priority));
                        if (isMatch)
                        {
                            matchCount++;
                            isExact = false;
                        }
                    }
                }

                var isPresent = matchCount > 0;

                if (isPresent)
                {
                    var checkTargetPoint = (int)Math.Ceiling((double)targets.Count() / 2);
                    var checkSourcePoint = (int)Math.Ceiling((double)sources.Count() / 2);
                    var isSourceLessEqualTarget = sources.Count() <= targets.Count();
                    var isSourceGreaterThanTarget = sources.Count() > targets.Count();

                    //priority = (matchCount == targets.Count() && matchCount == sources.Count() && isExact) ? Priority.P1 :
                    //                (matchCount == targets.Count() || (matchCount == sources.Count() && difference <= 1)) ? Priority.P2 :
                    //                    ((isSourceLessEqualTarget && matchCount >= checkTargetPoint) || (isSourceGreaterThanTarget && matchCount >= checkSourcePoint)) ? Priority.P3 :
                    //                        (((isSourceLessEqualTarget && targets.Count() - matchCount > 2) || (isSourceGreaterThanTarget && sources.Count() - matchCount > 2)) ? Priority.P5 : Priority.P4);

                    if (matchCount == targets.Count() && matchCount == sources.Count() && isExact)
                    {
                        priority = Priority.P1;
                    }
                    else if (matchCount == targets.Count() && matchCount == sources.Count() && !isExact)
                    {
                        priority = Priority.P2;
                    }
                    else if (((isSourceLessEqualTarget && matchCount >= checkTargetPoint) ||
                              (isSourceGreaterThanTarget && matchCount >= checkSourcePoint)) && (sources.Count() - matchCount) == 1)
                    {
                        priority = Priority.P3;
                    }
                    else if (((isSourceLessEqualTarget && matchCount >= checkTargetPoint) ||
                              (isSourceGreaterThanTarget && matchCount >= checkSourcePoint)) && (sources.Count() - matchCount) == 2)
                    {
                        priority = Priority.P4;
                    }
                    else
                    {
                        priority = Priority.P5;
                    }

                    if ((sources.Count() - matchCount >= 3) || (targets.Count() - matchCount >= 3) || (isMinDistance && priority >= Priority.P3))
                    {
                        isPresent = false;
                    }
                }

                return isPresent;
            }
            else if (!isSourceContainsSpecialCharacter && isTargetContainsSpecialCharacter)
            {
                var sNumber = -1;
                if (int.TryParse(source, out sNumber))
                {
                    return false;
                }
                else
                {
                    var isMatch = CompareSourceWithTargets(source, targets, out priority);
                    if (isMatch && isMinDistance && priority >= Priority.P3)
                    {
                        isMatch = false;
                    }
                    return isMatch;
                }
            }
            else if (isSourceContainsSpecialCharacter && !isTargetContainsSpecialCharacter)
            {
                var tNumber = -1;
                if (int.TryParse(target, out tNumber))
                {
                    return false;
                }
                else
                {
                    var isMatch = CompareSourceWithTargets(target, sources, out priority);
                    if (isMatch && isMinDistance && priority >= Priority.P3)
                    {
                        isMatch = false;
                    }
                    return isMatch;
                }
            }
            else
            {
                var isPresent = true;
                if (string.IsNullOrEmpty(source))
                {
                    isPresent = false;
                    return isPresent;
                }

                var sNumber = -1;
                if (int.TryParse(source, out sNumber))
                {
                    priority = Priority.P4;
                    var tNumber = -1;
                    if (int.TryParse(target, out tNumber))
                    {
                        return (sNumber == tNumber);
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (!source.Equals(target, StringComparison.OrdinalIgnoreCase))
                    {
                        var diff = Math.Abs(source.Length - target.Length);
                        var dist = LevenshteinDistance.Compute(source, target);
                        if (diff == 0 && source.Length == 1)
                        {
                            isPresent = false;
                        }
                        else
                        {
                            /// Source string and target string has different in length
                            /// Source string and target string has same in length but target length is greater than 2
                            if (source.Length >= ProgramConstant.Tolerance && target.Length > ProgramConstant.Tolerance)
                            {
                                if (dist == ProgramConstant.MinorTolerance || (target.Contains(source, StringComparison.OrdinalIgnoreCase) && diff <= 6))
                                {
                                    priority = Priority.P2;
                                }
                                else if (dist == ProgramConstant.Tolerance)
                                {
                                    priority = Priority.P3;
                                }
                                else
                                {
                                    isPresent = false;
                                }
                            }
                            else
                            {
                                if (diff == 0)
                                {
                                    if (dist > ProgramConstant.MinorTolerance)
                                    {
                                        isPresent = false;
                                    }
                                    else
                                    {
                                        priority = Priority.P2;
                                    }
                                }
                                else if (diff == dist && diff == ProgramConstant.MinorTolerance)
                                {
                                    priority = Priority.P2;
                                }
                                else
                                {
                                    isPresent = false;
                                }
                            }
                            if (isMinDistance && priority >= Priority.P3)
                            {
                                isPresent = false;
                            }
                        }
                    }
                    else
                    {
                        priority = Priority.P1;
                    }
                }
                return isPresent;
            }
        }

        private static bool CompareSourceWithTargets(string source, string[] targets, out Priority priority)
        {
            var isSourceContainsInTarget = targets.Contains(source);
            var isTargetContainsInSource = false;
            priority = Priority.P3;

            if (!isSourceContainsInTarget)
            {
                foreach (var target in targets)
                {
                    var diff = Math.Abs(source.Length - target.Length);
                    var dist = LevenshteinDistance.Compute(source, target);
                    if (diff <= ProgramConstant.MinorTolerance && 
                        (source.Length >= ProgramConstant.Tolerance && 
                            dist <= ProgramConstant.MinorTolerance || (target.Contains(source, StringComparison.OrdinalIgnoreCase) && diff <= 5)))
                    {
                        isTargetContainsInSource = true;
                        break;
                    }
                }
                if (targets.Count() == 2)
                {
                    priority = Priority.P4;
                }
                else
                {
                    priority = Priority.P5;
                }
            }
            else
            {
                if (targets.Count() == 2)
                {
                    priority = Priority.P3;
                }
                else
                {
                    priority = Priority.P5;
                }
            }
            return (isSourceContainsInTarget || isTargetContainsInSource);
        }

        public static string RemoveWhiteSpaces(string source)
        {
            return Regex.Replace(source, RegExpression.PresentWhiteSpaceExpression, string.Empty);
        }
    }

    public static class StringExtension
    {
        public static bool Contains(this string source, string target, StringComparison comparison)
        {
            return source.IndexOf(target, comparison) >= 0;
        }

        public static string SubString(this string source, int startIndex, int length)
        {
            var stringStartIndex = startIndex;
            var stringLength = length;

            if (length < 0)
            {
                stringStartIndex = startIndex + length + 1;
                stringLength = Math.Abs(length);
            }
            return source.Substring(stringStartIndex, stringLength);
        }

        public static string[] SplitString(this string source, string separator)
        {
            var literals = new List<string>() { CharacterLiteral.WhiteSpace };
            if (literals.Contains(separator))
            {
                return Regex.Split(source, separator);
            }
            else
            {
                return source.Split(new string[] { separator }, StringSplitOptions.None);
            }
        }

        public static string[] SplitString(this string source)
        {
            var literals = new[] { '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '-', '*', '/', '|', '=', '\"', ' ', ';', ',' };
            var output = source.Split(literals).ToList();
            output = output.Select(x => StringOperationUtility.RemoveWhiteSpaces(x)).Where(x => !string.IsNullOrEmpty(x)).ToList();

            return output.ToArray();
        }
    }
}

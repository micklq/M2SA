﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using M2SA.AppGenome.Logging;
using M2SA.AppGenome.Reflection;

namespace M2SA.AppGenome.Data.SqlMap
{
    /// <summary>
    /// 
    /// </summary>
    public class InKeyProcessor : IKeywordProcessor
    {
        static readonly Regex InKeyRegex = new Regex(@"\s+in\s*\(\s*@(?<word>[A-Za-z_]\w+)\s*\)", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        static readonly Regex InKeyWithIsNullRegex = new Regex(@"\s+in\s*\(\s*i[s|f]null\(\s*@(?<word>[A-Za-z_]\w+)\s*,\s*[^\)]+\)\s*\)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sqlText"></param>
        /// <param name="parameterValues"></param>
        /// <param name="escapeFunc"></param>
        /// <returns></returns>
        public KeywordProcessResult Process(string sqlText, IDictionary<string, object> parameterValues, Func<object, string> escapeFunc)
        {
            ArgumentAssertion.IsNotNull(sqlText, "sqlText");
            ArgumentAssertion.IsNotNull(escapeFunc, "escapeFunc");

            var result = new KeywordProcessResult();
            result.SqlExpression = sqlText;
            result.ParameterValues = parameterValues;

            ProcessByKeyRegex(InKeyRegex, sqlText, parameterValues, result);
            ProcessByKeyRegex(InKeyWithIsNullRegex, sqlText, parameterValues, result);
            return result;
        }

        private static void ProcessByKeyRegex(Regex keyRegex, string sqlText, IDictionary<string, object> parameterValues, KeywordProcessResult result)
        {
            var macthes = keyRegex.Matches(sqlText);
            var processedParams = new List<string>(macthes.Count);
            foreach (Match macth in macthes)
            {
                if (false == result.IsMatch) result.IsMatch = macth.Success;

                if (macth.Success)
                {
                    var expression = macth.Value;
                    var paramName = macth.Groups["word"].Value;

                    var paramKey = FindParamKey(paramName, parameterValues);
                    if (processedParams.Contains(paramName))
                        continue;
                    else if (null == paramKey)
                        throw new ArgumentOutOfRangeException(paramName, string.Format("Must define param :{0}", paramName));

                    var paramValue = parameterValues[paramKey];
                    if (null != paramValue && paramValue is IEnumerable)
                    {
                        processedParams.Add(paramName);
                        parameterValues.Remove(paramKey);

                        var paramBuilder = new StringBuilder();
                        var list = (IEnumerable) paramValue;
                        var index = 0;
                        foreach (var item in list)
                        {
                            var tempName = string.Format("@_{0}_{1}", paramName, index);
                            paramBuilder.AppendFormat("{0}{1}", index > 0 ? "," : "", tempName);
                            parameterValues.Add(tempName, item);
                            index++;
                        }

                        var expressionResult = string.Format(" in({0}) ", paramBuilder.ToString());

                        result.SqlExpression = result.SqlExpression.Replace(expression, expressionResult);
                        result.ParameterValues = parameterValues;
                    }
                }
            }
        }

        private static string FindParamKey(string paramName, IDictionary<string, object> parameterValues)
        {
            if (parameterValues.ContainsKey(paramName))
                return paramName;

            var name = paramName.ToLower();
            foreach (var item in parameterValues)
            {
                if (item.Key.ToLower() == name)
                    return item.Key;
            }

            return null;
        }
    }
}

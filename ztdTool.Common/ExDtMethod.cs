using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;

namespace ztdTool.Common
{
    /// <summary>
    /// DataTable扩展方法
    /// </summary>
    public static class ExDtMethod 
    {
        public static int GetRowCount(this DataTable dt)
        {
            return dt != null && dt.Rows.Count >= 0 ? dt.Rows.Count : -1;
        }

        /// <summary>
        /// 获取DataTable中符合某个条件的唯一记录
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="name"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static DataRow SingleOrDefault<T>(this DataTable dt, string name, Func<T, bool> func)
        {
            DataRow result = null;
            long count = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow current = dt.Rows[i];
                if (func((T)current[name]))
                {
                    count++;
                    result = current;
                }
            }
            switch (count)
            {
                case 0: return null;
                case 1: return result;
            }
            return result;
        }

        /// <summary>
        /// 从DataTable中获取某个字段组成的集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dt"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static IEnumerable<T> Select<T>(this DataTable dt, string name)
        {
            DataColumnCollection columns = dt.Columns;
            IList<T> iList = new List<T>(dt.Rows.Count);
            if (!columns.Contains(name)) return iList;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                iList.Add((T)dt.Rows[i][name]);
            }
            return iList;
        }
        public static IEnumerable<T> Select<T>(this DataTable dt, string name, Func<T, T> func)
        {
            DataColumnCollection columns = dt.Columns;
            IList<T> iList = new List<T>();
            if (!columns.Contains(name)) return iList;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                iList.Add(func((T)dt.Rows[i][name]));
            }
            return iList;
        }
 
    }
}

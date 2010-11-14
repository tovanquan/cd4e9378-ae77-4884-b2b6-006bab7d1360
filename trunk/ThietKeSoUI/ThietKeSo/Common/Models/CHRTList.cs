using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Web.UI.WebControls;
namespace thietkeso.Common.Models
{
    public class CHRTList<T> : List<T>
    {
        public const string NUMBERTYPE = "Int32";
        public const string DATETIMETYPE = "DateTime";
        public const string STRINGTYPE = "String";

        #region protected methods

        public DataTable GetTable()
        {
            DataTable dtReturn = new DataTable();

            try
            {
                if (this.Count > 0)
                {
                    dtReturn = ConstructDataTableSchema(this[0]);
                }

                DataRow dr;
                for (int i = 0; i < this.Count; ++i)
                {
                    dr = dtReturn.NewRow();
                    Type type = this[i].GetType();
                    MemberInfo[] members = type.GetProperties();

                    foreach (MemberInfo member in members)
                    {
                        string[] nameArray = member.Name.ToString().Split(
                                            Convert.ToChar(" "));
                        if (dtReturn.Columns.Contains(nameArray[0]))
                        {
                            PropertyInfo prop = type.GetProperty(nameArray[0]);
                            dr[nameArray[0]] = prop.GetValue(this[i], null);
                        }
                    }

                    dtReturn.Rows.Add(dr);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
            return dtReturn;
        }

        public CHRTList<T> FullSearch(string txtQuery)
        {
            CHRTList<T> lstResult = new CHRTList<T>();
            if (Count > 0)
            {
                Type type = this[0].GetType();
                MemberInfo[] members = type.GetProperties();
                int iColumnCount = members.Length;
                for (int i = 0; i < Count; ++i)
                {
                    for (int j = 0; j < iColumnCount; ++j)
                    {
                        string[] nameArray = members[j].Name.ToString().Split(
                            Convert.ToChar(" "));
                        PropertyInfo prop = type.GetProperty(nameArray[0]);
                        if (prop.GetValue(this[i], null).ToString().ToUpper().Contains(txtQuery.ToUpper()))
                        {
                            lstResult.Add(this[i]);
                            j = iColumnCount;
                        }

                    }
                }
            }
            return lstResult;
        }

        public CHRTList<T> FilterByColumn(DateTime? dtmMin, DateTime? dtmMax, int? iMin, int? iMax, string strQuery, string columnName)
        {
            CHRTList<T> lstResult = new CHRTList<T>();
            if (Count > 0)
            {
                Type type = this[0].GetType();
                PropertyInfo prop = type.GetProperty(columnName);
                Type valueType = prop.GetValue(this[0], null).GetType();
                string strTypeName = valueType.Name;
                switch (strTypeName)
                {
                    case DATETIMETYPE:
                        {
                            return FilterByDateTimeColumn(dtmMin, dtmMax, prop);
                        }
                    case NUMBERTYPE:
                        {
                            return FilterByNumberColumn(iMin, iMax, prop);
                        }
                    default:
                        {
                            return FilterByTextColumn(strQuery, prop);
                        }
                }
            }
            return lstResult;
        }
        #endregion

        private DataTable ConstructDataTableSchema(T item)
        {
            DataTable dataTable = new DataTable();
            Type type = item.GetType();
            MemberInfo[] members = type.GetProperties();
            foreach (MemberInfo member in members)
            {
                string name = member.Name.ToString();
                PropertyInfo prop = type.GetProperty(name);
                Type valueType = prop.GetValue(item, null).GetType();

                DataColumn column = new DataColumn(name, valueType);
                column.AllowDBNull = true;
                dataTable.Columns.Add(column);
            }
            return dataTable;
        }

        private CHRTList<T> FilterByDateTimeColumn(DateTime? dtmMin, DateTime? dtmMax, PropertyInfo prop)
        {
            CHRTList<T> lstResult = new CHRTList<T>();
            if (Count > 0)
            {
                if ((dtmMin != null) && (dtmMax == null))
                {
                    DateTime dtmTmpFrom = Utils.GetMinDateTimeInDay(dtmMin.Value);
                    for (int i = 0; i < Count; ++i)
                    {
                        DateTime? dtmValue = (DateTime?)prop.GetValue(this[i], null);
                        if (DateTime.Compare(dtmValue.Value, dtmTmpFrom) != -1)
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else if ((dtmMin == null) && (dtmMax != null))
                {
                    DateTime dtmTmpTo = Utils.GetMaxDateTimeInDay(dtmMax.Value);
                    for (int i = 0; i < Count; ++i)
                    {
                        DateTime? dtmValue = (DateTime?)prop.GetValue(this[i], null);
                        if (DateTime.Compare(dtmValue.Value, dtmTmpTo) != 1)
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else if ((dtmMin != null) && (dtmMax != null))
                {
                    DateTime dtmTmpFrom = Utils.GetMinDateTimeInDay(dtmMin.Value);
                    DateTime dtmTmpTo = Utils.GetMaxDateTimeInDay(dtmMax.Value);
                    for (int i = 0; i < Count; ++i)
                    {
                        DateTime? dtmValue = (DateTime?)prop.GetValue(this[i], null);
                        if ((DateTime.Compare(dtmValue.Value, dtmTmpTo) != 1) && (DateTime.Compare(dtmValue.Value, dtmTmpFrom) != -1))
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else
                {
                    return this;
                }
            }
            return lstResult;
        }

        private CHRTList<T> FilterByTextColumn(string strQuery, PropertyInfo prop)
        {
            CHRTList<T> lstResult = new CHRTList<T>();
            if (Count > 0)
            {
                if (!string.IsNullOrEmpty(strQuery))
                {

                    for (int i = 0; i < Count; ++i)
                    {
                        string strValue = (string)prop.GetValue(this[i], null);

                        if (strValue.ToUpper().Contains(strQuery.ToUpper()))
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }

            }
            return lstResult;
        }

        private CHRTList<T> FilterByNumberColumn(int? iMin, int? iMax, PropertyInfo prop)
        {
            CHRTList<T> lstResult = new CHRTList<T>();
            if (Count > 0)
            {
                if ((iMin != null) && (iMax == null))
                {
                    for (int i = 0; i < Count; ++i)
                    {
                        int? iValue = (int?)prop.GetValue(this[i], null);

                        if (iValue >= iMin)
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else if ((iMin == null) && (iMax != null))
                {
                    for (int i = 0; i < Count; ++i)
                    {
                        int? iValue = (int?)prop.GetValue(this[i], null);

                        if (iValue <= iMax)
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else if ((iMin != null) && (iMax != null))
                {
                    for (int i = 0; i < Count; ++i)
                    {
                        int? iValue = (int?)prop.GetValue(this[i], null);

                        if ((iMin <= iValue) && (iValue <= iMax))
                        {
                            lstResult.Add(this[i]);
                        }

                    }
                }
                else
                {
                    return this;
                }
            }
            return lstResult;
        }

        private string _propertyName;
        private bool _ascending;

        public void Sort(string propertyName, bool ascending)
        {
            if (_propertyName == propertyName && _ascending == ascending)
                _ascending = !ascending;
            else
            {
                _propertyName = propertyName;
                _ascending = ascending;
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            PropertyDescriptor propertyDesc = properties.Find(propertyName, true);

            PropertyComparer<T> pc = new PropertyComparer<T>(propertyDesc, (_ascending) ? ListSortDirection.Ascending : ListSortDirection.Descending);
            this.Sort(pc);
        }


    }

    public class Utils
    {
        public static DateTime GetMinDateTimeInDay(DateTime dtmValue)
        {
            return new DateTime(dtmValue.Year, dtmValue.Month, dtmValue.Day, 0, 0, 0);
        }
        public static DateTime GetMaxDateTimeInDay(DateTime dtmValue)
        {
            return new DateTime(dtmValue.Year, dtmValue.Month, dtmValue.Day, 23, 59, 59);
        }
    }

    /// <summary>
    /// Summary description for PropertyComparer
    /// </summary>
    public class PropertyComparer<T> : IComparer<T>
    {
        private PropertyDescriptor _property;

        
        private ListSortDirection _direction;

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            _property = property;
            _direction = direction;
        }

        #region IComparer<T>

        public int Compare(T xWord, T yWord)
        {
            object xValue = GetPropertyValue(xWord, _property.Name);
            object yValue = GetPropertyValue(yWord, _property.Name);

            if (_direction == ListSortDirection.Ascending)
            {
                return CompareAscending(xValue, yValue);
            }
            else
            {
                return CompareDescending(xValue, yValue);
            }
        }

        public bool Equals(T xWord, T yWord)
        {
            return xWord.Equals(yWord);
        }

        public int GetHashCode(T obj)
        {
            return obj.GetHashCode();
        }

        #endregion

        private int CompareAscending(object xValue, object yValue)
        {
            int result;

            if (xValue is IComparable)
            {
                result = ((IComparable)xValue).CompareTo(yValue);
            }
            // If values don't implement IComparer but are equivalent
            else if (xValue.Equals(yValue))
            {
                result = 0;
            }
            // Values don't implement IComparer and are not equivalent, so compare as string values
            else result = xValue.ToString().CompareTo(yValue.ToString());

            // Return result
            return result;
        }

        private int CompareDescending(object xValue, object yValue)
        {
            // Return result adjusted for ascending or descending sort order ie
            // multiplied by 1 for ascending or -1 for descending
            return CompareAscending(xValue, yValue) * -1;
        }

        private object GetPropertyValue(T value, string property)
        {
            // Get property
            PropertyInfo propertyInfo = value.GetType().GetProperty(property);

            // Return value
            return propertyInfo.GetValue(value, null);
        }
    }
}

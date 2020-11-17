﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGenerator
{
    public class Table
    {
        private string tableName;
        private List<TableColumn> tableColumn = new List<TableColumn>();

        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }

        public List<TableColumn> TableColumn
        {
            get
            {
                return tableColumn;
            }

            set
            {
                tableColumn = value;
            }
        }
    }

    public class TableColumn
    {
        private string tableName;
        private string columnName;
        private string isNullable;
        private string dataType;
        private string maxLength;

        public string ColumnName
        {
            get
            {
                return columnName;
            }

            set
            {
                columnName = value;
            }
        }

        public string IsNullable
        {
            get
            {
                return isNullable;
            }

            set
            {
                isNullable = value;
            }
        }

        public string DataType
        {
            get
            {
                return dataType;
            }

            set
            {
                dataType = value;
            }
        }

        public string MaxLength
        {
            get
            {
                return maxLength;
            }

            set
            {
                maxLength = value;
            }
        }

        public string TableName
        {
            get
            {
                return tableName;
            }

            set
            {
                tableName = value;
            }
        }
    }
}

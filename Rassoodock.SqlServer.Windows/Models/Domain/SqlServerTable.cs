﻿using System.Collections.Generic;

namespace Rassoodock.SqlServer.Windows.Models.Domain
{
    public class SqlServerTable
    {
        public SqlServerTable()
        {
            FileGroup = SqlServerConstants.PrimaryFileGroup;
            TextImageFileGroup = SqlServerConstants.PrimaryFileGroup;
        }

        public string FileGroup { get; set; }

        public string TextImageFileGroup { get; set; }

        public string Schema { get; set; }

        public string Name { get; set; }

        public IEnumerable<TableTrigger> Triggers { get; set; }

        public IEnumerable<Column> Columns { get; set; }

        public PrimaryKeyConstraint PrimaryKeyConstraint { get; set; }

        public IEnumerable<ForeignKeyConstraint> ForeignKeyConstraints { get; set; }

        public IEnumerable<Index> Indexes { get; set; }

        public IEnumerable<ObjectPermission> PermissionDeclarations { get; set; }
    }
}
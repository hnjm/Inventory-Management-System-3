﻿using FluentNHibernate.Automapping.Alterations;
using Inventory.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class InventoryProductDocumentMap : IAutoMappingOverride<InventoryProductDocument>
        {
            public void Override(FluentNHibernate.Automapping.AutoMapping<InventoryProductDocument> mapping)
            {
            }
        }
    }


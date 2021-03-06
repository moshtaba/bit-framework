﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace BitTools.Core.Model
{
    public class DtoController
    {
        public virtual string Name { get; set; }

        public virtual IList<ODataOperation> Operations { get; set; }

        public virtual INamedTypeSymbol ControllerSymbol { get; set; }

        public virtual ITypeSymbol ModelSymbol { get; set; }

        public override string ToString()
        {
            if (ControllerSymbol != null)
                return ControllerSymbol.Name;
            else
                return base.ToString();
        }
    }
}

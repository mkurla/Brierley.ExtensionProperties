﻿using Logic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces
{
    public interface IExtensionPropertyService
    {
        Task<IList<ExtensionPropertyDetails>> CreateExtensionProperties(IList<ExtensionPropertyDetails> extensionProperties);
    }
}
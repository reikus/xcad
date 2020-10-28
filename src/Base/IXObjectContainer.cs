﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Xarial.XCad
{
    /// <summary>
    /// Represents the environment which can contain objects in different states (e.g. component, document, drawing view)
    /// </summary>
    public interface IXObjectContainer
    {
        /// <summary>
        /// Converts pointer to object to the current environment container
        /// </summary>
        /// <typeparam name="TSelObject">Type of object</typeparam>
        /// <param name="obj">Pointer to object to convert</param>
        /// <returns>Converted pointer</returns>
        TSelObject ConvertObject<TSelObject>(TSelObject obj)
            where TSelObject : class, IXSelObject;
    }
}

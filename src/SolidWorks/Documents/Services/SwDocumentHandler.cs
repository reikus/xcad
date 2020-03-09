﻿using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Text;
using Xarial.XCad.Documents;
using Xarial.XCad.Documents.Services;

namespace Xarial.XCad.SolidWorks.Documents.Services
{
    public abstract class SwDocumentHandler : IDocumentHandler
    {
        protected const int S_OK = 0;
        protected const int S_FAIL = 1;

        protected ISldWorks Application { get; private set; }
        protected IModelDoc2 Model { get; private set; }

        public void Init(IXApplication app, IXDocument model)
        {
            Application = ((SwApplication)app).Sw;
            Model = ((SwDocument)model).Model;

            switch (Model)
            {
                case PartDoc part:
                    AttachPartEvents(part);
                    break;

                case AssemblyDoc assm:
                    AttachAssemblyEvents(assm);
                    break;

                case DrawingDoc drw:
                    AttachDrawingEvents(drw);
                    break;

                default:
                    throw new NotSupportedException("Not a SOLIDWORKS document");
            }
        }

        protected virtual void AttachPartEvents(PartDoc part) 
        {
        }

        protected virtual void AttachAssemblyEvents(AssemblyDoc assm)
        {
        }

        protected virtual void AttachDrawingEvents(DrawingDoc drw)
        {
        }

        protected virtual void DetachPartEvents(PartDoc part)
        {
        }

        protected virtual void DetachAssemblyEvents(AssemblyDoc assm)
        {
        }

        protected virtual void DetachDrawingEvents(DrawingDoc drw)
        {
        }

        public void Dispose()
        {
            switch (Model)
            {
                case PartDoc part:
                    DetachPartEvents(part);
                    break;

                case AssemblyDoc assm:
                    DetachAssemblyEvents(assm);
                    break;

                case DrawingDoc drw:
                    DetachDrawingEvents(drw);
                    break;

                default:
                    throw new NotSupportedException("Not a SOLIDWORKS document");
            }
        }
    }
}

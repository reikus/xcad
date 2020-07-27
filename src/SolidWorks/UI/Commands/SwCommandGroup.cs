﻿//*********************************************************************
//xCAD
//Copyright(C) 2020 Xarial Pty Limited
//Product URL: https://www.xcad.net
//License: https://xcad.xarial.com/license/
//*********************************************************************

using SolidWorks.Interop.sldworks;
using Xarial.XCad.SolidWorks.UI.Commands.Toolkit.Enums;
using Xarial.XCad.UI.Commands;
using Xarial.XCad.UI.Commands.Delegates;
using Xarial.XCad.UI.Commands.Structures;

namespace Xarial.XCad.SolidWorks.UI.Commands
{
    /// <inheritdoc/>
    public class SwCommandGroup : IXCommandGroup
    {
        /// <inheritdoc/>
        public event CommandClickDelegate CommandClick;

        /// <inheritdoc/>
        public event CommandStateDelegate CommandStateResolve;

        /// <inheritdoc/>
        public CommandGroup CommandGroup { get; }

        /// <inheritdoc/>
        public CommandGroupSpec Spec { get; }

        private readonly SwApplication m_App;

        internal SwCommandGroup(SwApplication app, CommandGroupSpec spec, CommandGroup cmdGroup)
        {
            Spec = spec;
            CommandGroup = cmdGroup;
            m_App = app;
        }

        internal void RaiseCommandClick(CommandSpec spec)
        {
            CommandClick?.Invoke(spec);
        }

        internal CommandItemEnableState_e RaiseCommandEnable(CommandSpec spec)
        {
            var state = new CommandState();
            state.ResolveState(spec.SupportedWorkspace, m_App);

            CommandStateResolve?.Invoke(spec, state);

            if (state.Enabled)
            {
                if (state.Checked)
                {
                    return CommandItemEnableState_e.SelectEnable;
                }
                else
                {
                    return CommandItemEnableState_e.DeselectEnable;
                }
            }
            else
            {
                if (state.Checked)
                {
                    return CommandItemEnableState_e.SelectDisable;
                }
                else
                {
                    return CommandItemEnableState_e.DeselectDisable;
                }
            }
        }
    }
}
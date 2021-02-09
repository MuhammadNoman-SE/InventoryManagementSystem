using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagementSystem.PrismClientCore
{
    public interface IApplicationCommands {
        CompositeCommand SendAll { get; }
    }
    public class ApplicationCommands : IApplicationCommands
    {
        public CompositeCommand SendAll { get; } = new CompositeCommand();
    }
}

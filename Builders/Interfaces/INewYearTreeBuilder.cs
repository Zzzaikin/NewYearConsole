using NewYearConsole.Models;
using System.Drawing;

namespace NewYearConsole.Builders.Interfaces
{
    internal interface INewYearTreeBuilder : IModelBuilder
    {
        void SetNewYearTreeColor(Color color);

        void SetGarland(Garland garland);
    }
}

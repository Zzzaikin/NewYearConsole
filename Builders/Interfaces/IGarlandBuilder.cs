using System.Drawing;

namespace NewYearConsole.Builders.Interfaces
{
    internal interface IGarlandBuilder : IModelBuilder
    {
        void SetMode(Mode mode);

        void SetPosition(Point point);

        void SetColor(Color color);
    }
}

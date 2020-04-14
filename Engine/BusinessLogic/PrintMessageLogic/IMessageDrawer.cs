using System.Collections.Generic;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic.PrintMessageLogic
{
    public interface IMessageDrawer
    {
        public void Draw(List<PixelInformation> message);
    }
}
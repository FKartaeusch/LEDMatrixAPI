using System.Collections.Generic;
using IconsAndFonts.Icons;

namespace Engine.BusinessLogic
{
    public interface IMessageDrawer
    {
        public void Draw(List<PixelInformation> message);
    }
}
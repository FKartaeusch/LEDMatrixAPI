using IconsAndFonts.Fonts.Base;

namespace IconsAndFonts.Fonts
{
    public class PixelFont

    {
        public BaseLetters Letters;

        public BaseNumbers Numbers;
        public BaseSpecialSigns SpecialSigns;

        public PixelFont(BaseLetters letters, BaseNumbers numbers, BaseSpecialSigns specialSigns)
        {
            Numbers = numbers;
            SpecialSigns = specialSigns;
            Letters = letters;
        }
    }
}
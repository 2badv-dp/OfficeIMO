using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;

namespace OfficeIMO.Word {
    public partial class WordParagraph {

        public bool Bold {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Bold != null) {
                    return true;
                } else {
                    return false;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value == true) {
                    runProperties.Bold = new Bold();
                    runProperties.BoldComplexScript = new BoldComplexScript();
                } else {
                    if (runProperties.BoldComplexScript != null) {
                        runProperties.BoldComplexScript.Remove();
                    }

                    if (runProperties.Bold != null) {
                        runProperties.Bold.Remove();
                    }
                }
            }
        }

        public bool Italic {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Italic != null) {
                    return true;
                } else {
                    return false;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != true) {
                    runProperties.Italic = null;
                } else {
                    runProperties.Italic = new Italic { };
                }
            }
        }

        public UnderlineValues? Underline {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Underline != null) {
                    return runProperties.Underline.Val;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != null) {
                    if (runProperties.Underline == null) {
                        runProperties.Underline = new Underline();
                    }

                    runProperties.Underline.Val = value;
                } else {
                    if (runProperties.Underline != null) runProperties.Underline.Remove();
                }
            }
        }

        public bool DoNotCheckSpellingOrGrammar {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.NoProof != null) {
                    return true;
                } else {
                    return false;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != true) {
                    if (runProperties.NoProof != null) runProperties.NoProof.Remove();
                } else {
                    runProperties.NoProof = new NoProof();
                }
            }
        }

        public int? Spacing {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Spacing != null) {
                    return runProperties.Spacing.Val;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != null) {
                    Spacing spacing = new Spacing();
                    spacing.Val = value;
                    runProperties.Spacing = spacing;
                } else {
                    if (runProperties.Spacing != null) runProperties.Spacing.Remove();
                }
            }
        }

        public bool Strike {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Strike != null) {
                    return true;
                } else {
                    return false;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != true) {
                    if (runProperties.Strike != null) runProperties.Strike.Remove();
                } else {
                    runProperties.Strike = new Strike();
                }
            }
        }

        public bool DoubleStrike {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.DoubleStrike != null) {
                    return true;
                } else {
                    return false;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != true) {
                    if (runProperties.DoubleStrike != null) runProperties.DoubleStrike.Remove();
                } else {
                    runProperties.DoubleStrike = new DoubleStrike();
                }
            }
        }
        public int? FontSize {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.FontSize != null) {
                    var fontSizeInHalfPoint = int.Parse(runProperties.FontSize.Val);
                    return fontSizeInHalfPoint / 2;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != null) {
                    FontSize fontSize = new FontSize();
                    fontSize.Val = (value * 2).ToString();
                    runProperties.FontSize = fontSize;
                } else {
                    if (runProperties.FontSize != null) runProperties.FontSize.Remove();
                }
            }
        }

        public SixLabors.ImageSharp.Color Color {
            get { return SixLabors.ImageSharp.Color.Parse("#" + ColorHex); }
            set { this.ColorHex = value.ToHexColor(); }
        }

        public string ColorHex {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Color != null) {
                    return runProperties.Color.Val;
                } else {
                    return "";
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != "") {
                    var color = new DocumentFormat.OpenXml.Wordprocessing.Color();
                    color.Val = value.Replace("#", "");
                    runProperties.Color = color;
                } else {
                    if (runProperties.Color != null) runProperties.Color.Remove();
                }
            }
        }

        public ThemeColorValues? ThemeColor {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Color != null && runProperties.Color.ThemeColor != null) {
                    return runProperties.Color.ThemeColor.Value;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value != null) {
                    var color = new DocumentFormat.OpenXml.Wordprocessing.Color {
                        ThemeColor = new EnumValue<ThemeColorValues> {
                            Value = value.Value
                        }
                    };
                    runProperties.Color = color;
                } else {
                    if (runProperties.Color != null) runProperties.Color.Remove();
                }
            }
        }

        public HighlightColorValues? Highlight {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Highlight != null) {
                    return runProperties.Highlight.Val;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                var highlight = new Highlight {
                    Val = value
                };
                runProperties.Highlight = highlight;
            }
        }

        public CapsStyle CapsStyle {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.Caps != null) {
                    return CapsStyle.Caps;
                } else if (runProperties != null && runProperties.SmallCaps != null) {
                    return CapsStyle.SmallCaps;
                } else {
                    return CapsStyle.None;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                if (value == CapsStyle.None) {
                    runProperties.Caps = null;
                    runProperties.SmallCaps = null;
                } else if (value == CapsStyle.Caps) {
                    runProperties.Caps = new Caps();
                    runProperties.SmallCaps = null;
                } else if (value == CapsStyle.SmallCaps) {
                    runProperties.SmallCaps = new SmallCaps();
                    runProperties.Caps = null;
                }
            }
        }

        public string FontFamily {
            get {
                var runProperties = IsHyperLink ? this.Hyperlink._runProperties : _runProperties;
                if (runProperties != null && runProperties.RunFonts != null) {
                    return runProperties.RunFonts.Ascii;
                } else {
                    return null;
                }
            }
            set {
                RunProperties runProperties;
                if (IsHyperLink) {
                    VerifyRunProperties(this.Hyperlink._hyperlink, this.Hyperlink._run, this.Hyperlink._runProperties);
                    runProperties = this.Hyperlink._runProperties;
                } else {
                    VerifyRunProperties();
                    runProperties = _runProperties;
                }
                runProperties.RunFonts = new RunFonts {
                    Ascii = value
                };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarAircraftDesign
{
    public class Wingspan
    {
        private double Value=1;
        private string Symbol = "b";

        public void Set(double Wingspan)
        {
            Value = Wingspan;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class CruiseVelocity
    {
        private double Value = 1;
        private string Symbol = "v_{cr}";

        public void Set(double CruiseVelocity)
        {
            Value = CruiseVelocity;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class WingSweep
    {
        private double Value = 1;
        private string Symbol = @"\Lambda";

        public void Set(double WingSweep)
        {
            Value = WingSweep;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class Chord
    {
        private double Value = 1;
        private string Symbol = @"c";

        public void Set(double Chord)
        {
            Value = Chord;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class Thickness
    {
        private double Value = 1;
        private string Symbol = @"t";

        public void Set(double Thickness)
        {
            Value = Thickness;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class SurfaceArea
    {
        private double Value = 1;
        private string Symbol = @"S";

        public void Set(double SurfaceArea)
        {
            Value = SurfaceArea;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class PressureForce
    {
        private double Value = 1;
        private string Symbol = @"P";

        public void Set(double PressureForce)
        {
            Value = PressureForce;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class ShearForce
    {
        private double Value = 1;
        private string Symbol = @"\mathrm{T}";

        public void Set(double ShearForce)
        {
            Value = ShearForce;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class RootChord
    {
        private double Value = 1;
        private string Symbol = @"c_{r}";

        public void Set(double RootChord)
        {
            Value = RootChord;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class TipChord
    {
        private double Value = 1;
        private string Symbol = @"c_{t}";

        public void Set(double TipChord)
        {
            Value = TipChord;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class TaperRatio
    {
        private double Value = 1;
        private string Symbol = @"\lambda";

        public void Set(double TaperRatio)
        {
            Value = TaperRatio;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class RelativeVelocity
    {
        private double Value = 1;
        private string Symbol = @"V_{\infty}";

        public void Set(double RelativeVelocity)
        {
            Value = RelativeVelocity;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class AngleOfAttack
    {
        private double Value = 1;
        private string Symbol = @"\alpha";

        public void Set(double AngleOfAttack)
        {
            Value = AngleOfAttack;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class ResultantAerodynamicForce
    {
        private double Value = 1;
        private string Symbol = @"R";

        public void Set(double ResultantAerodynamicForce)
        {
            Value = ResultantAerodynamicForce;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class LiftForce
    {
        private double Value = 1;
        private string Symbol = @"L";

        public void Set(double LiftForce)
        {
            Value = LiftForce;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class DragForce
    {
        private double Value = 1;
        private string Symbol = @"D";

        public void Set(double DragForce)
        {
            Value = DragForce;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class TorsionalMomentQuarterChord
    {
        private double Value = 1;
        private string Symbol = @"M_{\frac{c}{4}}";

        public void Set(double TorsionalMomentQuarterChord)
        {
            Value = TorsionalMomentQuarterChord;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class CenterOfPressure
    {
        private double Value = 1;
        private string Symbol = @"C_{p}";

        public void Set(double CenterOfPressure)
        {
            Value = CenterOfPressure;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class RelativeDensity
    {
        private double Value = 1;
        private string Symbol = @"\rho_{\infty}";

        public void Set(double RelativeDensity)
        {
            Value = RelativeDensity;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }

    public class RelativeDynamicViscosity
    {
        private double Value = 1;
        private string Symbol = @"\mu_{\infty}";

        public void Set(double RelativeDynamicViscosity)
        {
            Value = RelativeDynamicViscosity;
        }

        public string Latex()
        {
            return Symbol;
        }

        public double Get()
        {
            return Value;
        }
    }
}

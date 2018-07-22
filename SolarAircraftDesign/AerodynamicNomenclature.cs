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
        private string Symbol = @"CP";

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

    public class KinematicViscosity
    {
        private double Value = 1;
        private string Symbol = @"v";

        public void Set(double KinematicViscosity)
        {
            Value = KinematicViscosity;
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

    public class RelativeCompressibility
    {
        private double Value = 1;
        private string Symbol = @"a_{\infty}";

        public void Set(double RelativeCompressibility)
        {
            Value = RelativeCompressibility;
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

    public class LiftCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{L}";

        public void Set(double LiftCoefficient)
        {
            Value = LiftCoefficient;
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

    public class ProfileLiftCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{l}";

        public void Set(double ProfileLiftCoefficient)
        {
            Value = ProfileLiftCoefficient;
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

    public class DragCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{D}";

        public void Set(double DragCoefficient)
        {
            Value = DragCoefficient;
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

    public class ProfileDragCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{d}";

        public void Set(double ProfileDragCoefficient)
        {
            Value = ProfileDragCoefficient;
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


    public class ProfileMomentCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{m}";

        public void Set(double MomentCoefficient)
        {
            Value = MomentCoefficient;
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

    public class LiftCurveSlope
    {
        private double Value = 1;
        private string Symbol = @"a_{0}";

        public void Set(double LiftCurveSlope)
        {
            Value = LiftCurveSlope;
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

    public class ZeroLiftAngleOfAttack
    {
        private double Value = 1;
        private string Symbol = @"\alpha_{l=0}";

        public void Set(double ZeroLiftAngleOfAttack)
        {
            Value = ZeroLiftAngleOfAttack;
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

    public class MaxLiftCoefficient
    {
        private double Value = 1;
        private string Symbol = @"\C_{l_{max}}";

        public void Set(double MaxLiftCoefficient)
        {
            Value = MaxLiftCoefficient;
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

    public class MomentCurveSlope
    {
        private double Value = 1;
        private string Symbol = @"m_{0}";

        public void Set(double MomentCurveSlope)
        {
            Value = MomentCurveSlope;
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

    public class MinimumDragCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{d_{min}}";

        public void Set(double MinimumDragCoefficient)
        {
            Value = MinimumDragCoefficient;
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

    public class AerodynamicCenter
    {
        private double Value = 1;
        private string Symbol = @"x_{ac}";

        public void Set(double AerodynamicCenter)
        {
            Value = AerodynamicCenter;
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

    public class AspectRatio
    {
        private double Value = 1;
        private string Symbol = @"AR";

        public void Set(double AspectRatio)
        {
            Value = AspectRatio;
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

    public class IncidenceAngle
    {
        private double Value = 1;
        private string Symbol = @"\alpha_{i}";

        public void Set(double IncidenceAngle)
        {
            Value = IncidenceAngle;
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

    public class EffectiveAngleOfAttack
    {
        private double Value = 1;
        private string Symbol = @"\alpha_{eff}";

        public void Set(double EffectiveAngleOfAttack)
        {
            Value = EffectiveAngleOfAttack;
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

    public class GeometricAngleOfAttack
    {
        private double Value = 1;
        private string Symbol = @"\alpha_{g}";

        public void Set(double GeometricAngleOfAttack)
        {
            Value = GeometricAngleOfAttack;
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

    public class MomentCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{M}";

        public void Set(double MomentCoefficient)
        {
            Value = MomentCoefficient;
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

    public class RelativeDynamicPressure
    {
        private double Value = 1;
        private string Symbol = @"q_{\infty}";

        public void Set(double RelativeDynamicPressure)
        {
            Value = RelativeDynamicPressure;
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

    public class EfficiencyFactor
    {
        private double Value = 1;
        private string Symbol = @"e";

        public void Set(double EfficiencyFactor)
        {
            Value = EfficiencyFactor;
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

    public class NormalForceCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{N}";

        public void Set(double NormalForceCoefficient)
        {
            Value = NormalForceCoefficient;
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

    public class WingLengthDelta
    {
        private double Value = 1;
        private string Symbol = @"l";

        public void Set(double WingLengthDelta)
        {
            Value = WingLengthDelta;
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

    public class FrictionCoefficientOnWetSurface
    {
        private double Value = 1;
        private string Symbol = @"C_{f}";

        public void Set(double FrictionCoefficientOnWetSurface)
        {
            Value = FrictionCoefficientOnWetSurface;
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

    public class SeperationOfFlowPressureDragCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{d.p}";

        public void Set(double SeperationOfFlowPressureDragCoefficient)
        {
            Value = SeperationOfFlowPressureDragCoefficient;
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

    public class InducedDragCoefficient
    {
        private double Value = 1;
        private string Symbol = @"C_{D_{i}}";

        public void Set(double InducedDragCoefficient)
        {
            Value = InducedDragCoefficient;
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

    public class InducedDragFactor
    {
        private double Value = 1;
        private string Symbol = @"\delta";

        public void Set(double InducedDragFactor)
        {
            Value = InducedDragFactor;
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

    public class Weight
    {
        private double Value = 1;
        private string Symbol = @"W";

        public void Set(double Weight)
        {
            Value = Weight;
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

    public class ParasiteDragAtZeroLift
    {
        private double Value = 1;
        private string Symbol = @"C_{D_{0}}";

        public void Set(double ParasiteDragAtZeroLift)
        {
            Value = ParasiteDragAtZeroLift;
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

    public class ParasiteDrag
    {
        private double Value = 1;
        private string Symbol = @"C_{D_{e}}";

        public void Set(double ParasiteDrag)
        {
            Value = ParasiteDrag;
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

    public class DragDueToShock
    {
        private double Value = 1;
        private string Symbol = @"C_{D_{w}}";

        public void Set(double DragDueToShock)
        {
            Value = DragDueToShock;
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

    public class ConstantOfProportionalityForPortionsOfDrag
    {
        private double Value = 1;
        private string Symbol = @"K";

        public void Set(double ConstantOfProportionalityForPortionsOfDrag)
        {
            Value = ConstantOfProportionalityForPortionsOfDrag;
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

    public class Velocity
    {
        private double Value = 1;
        private string Symbol = @"V";

        public void Set(double Velocity)
        {
            Value = Velocity;
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

    public class Thrust
    {
        private double Value = 1;
        private string Symbol = @"T";

        public void Set(double Thrust)
        {
            Value = Thrust;
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

    public class Mass
    {
        private double Value = 1;
        private string Symbol = @"m";

        public void Set(double Mass)
        {
            Value = Mass;
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

    public class AccelerationDueToGravity
    {
        private double Value = 1;
        private string Symbol = @"g";

        public void Set(double AccelerationDueToGravity)
        {
            Value = AccelerationDueToGravity;
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

    public class ReynoldsNumber
    {
        private double Value = 1;
        private string Symbol = @"Re";

        public void Set(double ReynoldsNumber)
        {
            Value = ReynoldsNumber;
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

    public class RelativeMachNumber
    {
        private double Value = 1;
        private string Symbol = @"M_{\infty}";

        public void Set(double RelativeMachNumber)
        {
            Value = RelativeMachNumber;
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

    public class WetSurfaceArea
    {
        private double Value = 1;
        private string Symbol = @"S_{wet}";

        public void Set(double WetSurfaceArea)
        {
            Value = WetSurfaceArea;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarAircraftDesign
{
    public class PowerForStraightLevelFlight
    {
        private double Value = 1;
        private string Symbol = "P_{lev}";

        public void Set(double PowerForStraightLevelFlight)
        {
            Value = PowerForStraightLevelFlight;
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

    public class TotalConsumedElectricalPower
    {
        private double Value = 1;
        private string Symbol = "P_{elec tot}";

        public void Set(double TotalConsumedElectricalPower)
        {
            Value = TotalConsumedElectricalPower;
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

    public class MotorEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{mot}";

        public void Set(double MotorEfficiency)
        {
            Value = MotorEfficiency;
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

    public class ControllerEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{ctrl}";

        public void Set(double ControllerEfficiency)
        {
            Value = ControllerEfficiency;
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

    public class GearboxEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{grb}";

        public void Set(double GearboxEfficiency)
        {
            Value = GearboxEfficiency;
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

    public class PropellerEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{plr}";

        public void Set(double PropellerEfficiency)
        {
            Value = PropellerEfficiency;
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

    public class BatteryEliminatorCircuitEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{BEC}";

        public void Set(double BatteryEliminatorCircuitEfficiency)
        {
            Value = BatteryEliminatorCircuitEfficiency;
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

    public class PowerConsumedByAvionics
    {
        private double Value = 1;
        private string Symbol = @"P_{av}";

        public void Set(double PowerConsumedByAvionics)
        {
            Value = PowerConsumedByAvionics;
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

    public class PowerConsumedByPayload
    {
        private double Value = 1;
        private string Symbol = @"P_{pld}";

        public void Set(double PowerConsumedByPayload)
        {
            Value = PowerConsumedByPayload;
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

    public class DailyEnergyRequired
    {
        private double Value = 1;
        private string Symbol = @"E_{elec tot}";

        public void Set(double DailyEnergyRequired)
        {
            Value = DailyEnergyRequired;
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

    public class BatteryChargeEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{chrd}";

        public void Set(double BatteryChargeEfficiency)
        {
            Value = BatteryChargeEfficiency;
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

    public class BatteryDischargeEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{dchrd}";

        public void Set(double BatteryDischargeEfficiency)
        {
            Value = BatteryDischargeEfficiency;
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

    public class DailySolarIrradiance
    {
        private double Value = 1;
        private string Symbol = @"T_{day}";

        public void Set(double DailySolarIrradiance)
        {
            Value = DailySolarIrradiance;
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

    public class NightlySolarIrradiance
    {
        private double Value = 1;
        private string Symbol = @"T_{night}";

        public void Set(double NightlySolarIrradiance)
        {
            Value = NightlySolarIrradiance;
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

    public class MaximumIrradiance
    {
        private double Value = 1;
        private string Symbol = @"I_{max}";

        public void Set(double MaximumIrradiance)
        {
            Value = MaximumIrradiance;
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

    public class DailySolarEnergyPerSquareMeter
    {
        private double Value = 1;
        private string Symbol = @"E_{day density}";

        public void Set(double DailySolarEnergyPerSquareMeter)
        {
            Value = DailySolarEnergyPerSquareMeter;
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

    public class IrradianceWeatherFactor
    {
        private double Value = 1;
        private string Symbol = @"\eta_{wthr}";

        public void Set(double IrradianceWeatherFactor)
        {
            Value = IrradianceWeatherFactor;
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

    public class AreaOfSolarCells
    {
        private double Value = 1;
        private string Symbol = @"A_{SC}";

        public void Set(double AreaOfSolarCells)
        {
            Value = AreaOfSolarCells;
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

    public class EfficiencyOfSolarCells
    {
        private double Value = 1;
        private string Symbol = @"\eta_{SC}";

        public void Set(double EfficiencyOfSolarCells)
        {
            Value = EfficiencyOfSolarCells;
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

    public class EfficiencyOfMaximumPowerPointTracker
    {
        private double Value = 1;
        private string Symbol = @"\eta_{MPPT}";

        public void Set(double EfficiencyOfMaximumPowerPointTracker)
        {
            Value = EfficiencyOfMaximumPowerPointTracker;
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

    public class AngleOfIncidenceOfSolarRadiationOnSolarCells
    {
        private double Value = 1;
        private string Symbol = @"\theta";

        public void Set(double AngleOfIncidenceOfSolarRadiationOnSolarCells)
        {
            Value = AngleOfIncidenceOfSolarRadiationOnSolarCells;
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

    public class SmallerAngleOfIncidenceOfSolarRadiationOnSolarCells
    {
        private double Value = 1;
        private string Symbol = @"\theta_1";

        public void Set(double SmallerAngleOfIncidenceOfSolarRadiationOnSolarCells)
        {
            Value = SmallerAngleOfIncidenceOfSolarRadiationOnSolarCells;
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

    public class CurvatureEfficiency
    {
        private double Value = 1;
        private string Symbol = @"\eta_{cbr}";

        public void Set(double CurvatureEfficiency)
        {
            Value = CurvatureEfficiency;
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

    public class FixedMass
    {
        private double Value = 1;
        private string Symbol = @"m_{fixed}";

        public void Set(double FixedMass)
        {
            Value = FixedMass;
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

    public class PayloadMass
    {
        private double Value = 1;
        private string Symbol = @"m_{pld}";

        public void Set(double PayloadMass)
        {
            Value = PayloadMass;
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

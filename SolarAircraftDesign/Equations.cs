using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarAircraftDesign
{
    public struct EquationReturnType<T>
    {
        public T Data;
        public string Latex;
    }

    public static class Equations
    {

        /// <summary>
        /// Lift = Weight Condition
        /// </summary>
        /// <param name="m">Mass of Aircraft</param>
        /// <param name="g">Acceleration Due to Gravity on Planet at Altitude</param>
        /// <param name="Cl">Coefficient of Lift of Wing</param>
        /// <param name="rho">Density of Air on Planet at Altitude</param>
        /// <param name="S">Surface Area of Wing</param>
        /// <returns>Velocity needed for straight level flight</returns>
        public static EquationReturnType<Velocity> GetVelocity(Mass m, AccelerationDueToGravity g, LiftCoefficient Cl, Density rho, SurfaceArea S)
        {
            EquationReturnType<Velocity> ToReturn = new EquationReturnType<Velocity>();
            ToReturn.Data = new Velocity();
            ToReturn.Data.Set(Math.Sqrt((2 * m.Get() * g.Get()) / (Cl.Get() * rho.Get() * S.Get())));
            ToReturn.Latex = @"\sqrt{\frac{2\cdot " + m.Latex()+@"\cdot "+g.Latex()+"}{"+Cl.Latex()+@"\cdot "+rho.Latex()+@"\cdot "+S.Latex()+"}}";
            return ToReturn;
        }

        /// <summary>
        /// Thrust = Drag Condition
        /// </summary>
        /// <param name="Cd">Coefficient of Drag of Wing</param>
        /// <param name="rho">Density of Air on Planet at Altitude</param>
        /// <param name="S">Surface Area of Wing</param>
        /// <param name="v">Velocity of Aircraft</param>
        /// <returns>Thrust to meet Thrust=Drag Condition</returns>
        public static EquationReturnType<Thrust> GetThrust(DragCoefficient Cd, Density rho, SurfaceArea S, Velocity v)
        {
            EquationReturnType<Thrust> ToReturn = new EquationReturnType<Thrust>();
            ToReturn.Data = new Thrust();
            ToReturn.Data.Set(Cd.Get() * rho.Get() / 2.0 * S.Get() * v.Get() * v.Get());
            ToReturn.Latex = Cd.Latex()+@"\cdot \frac{" + rho.Latex() + @"}{2}\cdot " + S.Latex() + @"\cdot " + v.Latex() + @"^{2}";
            return ToReturn;
        }

        /// <summary>
        /// Power = Force * Velocity Condition
        /// </summary>
        /// <param name="T">Thrust of Aircraft</param>
        /// <param name="v">Velocity of Aircraft</param>
        /// <returns>Power for Straight and Level Flight at Thrust and Velocity</returns>
        public static EquationReturnType<PowerForStraightLevelFlight> GetPowerForStraightLevelFlight(Thrust T, Velocity v)
        {
            EquationReturnType<PowerForStraightLevelFlight> ToReturn = new EquationReturnType<PowerForStraightLevelFlight>();
            ToReturn.Data = new PowerForStraightLevelFlight();
            ToReturn.Data.Set(T.Get() * v.Get());
            ToReturn.Latex = T.Latex() + @"\cdot " + v.Latex();
            return ToReturn;
        }

        /// <summary>
        /// Power = Force * Velocity Condition
        /// </summary>
        /// <param name="Cd">Drag Coefficient of Wing</param>
        /// <param name="Cl">Lift Coefficient of Wing</param>
        /// <param name="g">Acceleration Due to Gravity At Altitude on Planet</param>
        /// <param name="m">Mass of Aircraft</param>
        /// <param name="rho">Density of Air At Altitude on Planet</param>
        /// <param name="S">Surface Area of Wing</param>
        /// <returns>Power for Straight and Level Flight at Thrust and Velocity</returns>
        public static EquationReturnType<PowerForStraightLevelFlight> GetPowerForStraightLevelFlight(DragCoefficient Cd, LiftCoefficient Cl, Mass m, AccelerationDueToGravity g, SurfaceArea S, Density rho)
        {
            EquationReturnType<PowerForStraightLevelFlight> ToReturn = new EquationReturnType<PowerForStraightLevelFlight>();
            ToReturn.Data = new PowerForStraightLevelFlight();
            ToReturn.Data.Set( (Cd.Get()/Math.Pow(Cl.Get(),3.0/2.0)) * Math.Sqrt((Math.Pow(m.Get()*g.Get(),3)/S.Get())) * (Math.Sqrt(2/rho.Get())));
            ToReturn.Latex = @"\frac{" + Cd.Latex() + "}{" + Cl.Latex() + @"^{3/2}}\cdot \sqrt{\frac{(" + m.Latex() + @"\cdot " + g.Latex() + ")^{3}}{" + S.Latex() + @"}}\cdot \sqrt{\frac{2}{" + rho.Latex() + "}}";
            return ToReturn;
        }

        public static EquationReturnType<TotalConsumedElectricalPower> GetTotalConsumedPower(ControllerEfficiency nctrl, MotorEfficiency nmot, GearboxEfficiency ngrb, PropellerEfficiency nplr, PowerForStraightLevelFlight Plev, BatteryEliminatorCircuitEfficiency nbec, PowerConsumedByAvionics pav, PowerConsumedByPayload pld)
        {
            EquationReturnType<TotalConsumedElectricalPower> ToReturn = new EquationReturnType<TotalConsumedElectricalPower>();
            ToReturn.Data = new TotalConsumedElectricalPower();
            ToReturn.Data.Set((1/(nctrl.Get()*nmot.Get()*ngrb.Get()*nplr.Get()))*Plev.Get()+(1/nbec.Get())*(pav.Get()+pld.Get()));
            ToReturn.Latex = @"\frac{1}{" + nctrl.Latex() + @"\cdot " + nmot.Latex() + @"\cdot "+ngrb.Latex()+@"\cdot "+nplr.Latex()+@"}\cdot "+Plev.Latex()+@"+\frac{1}{"+nbec.Latex()+@"}\cdot (" +pav.Latex()+"+"+pld.Latex()+ @")";
            return ToReturn;
        }
    }
}

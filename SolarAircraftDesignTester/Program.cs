using SolarAircraftDesign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarAircraftDesignTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Mass m = new Mass();
            m.Set(100);
            AccelerationDueToGravity g = new AccelerationDueToGravity();
            g.Set(9.81);
            LiftCoefficient Cl = new LiftCoefficient();
            Cl.Set(.5);
            Density rho = new Density();
            rho.Set(1.225);
            SurfaceArea S = new SurfaceArea();
            S.Set(100);
            DragCoefficient Cd = new DragCoefficient();
            Cd.Set(.05);
            var vel = Equations.GetVelocity(m,g,Cl,rho,S);
            Console.WriteLine(vel.Latex);
            var thr = Equations.GetThrust(Cd, rho, S, vel.Data);
            Console.WriteLine(thr.Latex);
            var pow1 = Equations.GetPowerForStraightLevelFlight(thr.Data, vel.Data);
            Console.WriteLine(pow1.Latex);
            var pow2 = Equations.GetPowerForStraightLevelFlight(Cd, Cl, m, g, S, rho);
            Console.WriteLine(pow2.Latex);
            Console.WriteLine(pow1.Data.Get() + " " + pow2.Data.Get());

        }
    }
}

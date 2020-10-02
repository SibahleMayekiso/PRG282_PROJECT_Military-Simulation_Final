using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_PROJECT_Military_Simulations
{
    class Report
    {
        //use this method when the gameover event is triggered
        private static string generateReport(int aircraftHealth, int fuel, int enemCampHealth, int ammo, int score)
        {
            string FinalAnalysis;

            string AllyHealth;
            string FuelStatus;
            string EnemyHealth;
            string Inventory;
            string Damage;


            if (aircraftHealth > 70)
            {
                AllyHealth = "Current Aircraft Health:" + aircraftHealth + "\n Aircraft is in great condition";
            }
            else if(aircraftHealth > 25 && aircraftHealth < 40)
            {
                AllyHealth = "Current Aircraft Health:" + aircraftHealth + "\n Aircraft has suffered considerable damage";
            }
            else
            {
                AllyHealth = "Current Aircraft Health:" + aircraftHealth + "\n Aircraft is in critical condition";
            }
            
            //Different criteria can be assignd using if statement like the code  above 
            FuelStatus = "Current Fuel:" + fuel;
            EnemyHealth = "Current Enemy Camp Health: " + aircraftHealth;
            Inventory = "Current Ammunition available: " + ammo;
            Damage = "Current Damage inflicted on enemy: " + score;
            ////

            //Condition checking to determine final analysis
            if (aircraftHealth > 75 && enemCampHealth < 1 && score > 1)
            {
                FinalAnalysis = "Mission Was Very Successfull.\n Enemy suffered multiple casualities with minimal reporcusions for Aircraft";
            }
            else if(aircraftHealth > 50 && enemCampHealth < 1 && score > 1)
            {
                FinalAnalysis = "Mission Was Very Successfull.\n Enemy suffered multiple casualities with moderate reporcusions for Aircraft";
            }
            else if (aircraftHealth > 25 && enemCampHealth < 1 && score > 1)
            {
                FinalAnalysis = "Mission Was Very Successfull.\n Enemy suffered multiple casualities with fairly heavy reporcusions for Aircraft";
            }
            else if (aircraftHealth > 1)
            {
                FinalAnalysis = "Mission Was Unsuccessful";
            }
            else
            {
                FinalAnalysis = "Mission Was Unsuccessful";
            }


            return AllyHealth + "\n" + FuelStatus + "\n" + EnemyHealth + "\n" + Inventory + "\n" + Damage + "\n" + FinalAnalysis;
        }
    }
}

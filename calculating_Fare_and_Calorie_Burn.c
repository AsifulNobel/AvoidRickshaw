//
//  main.c
//  Avoid Rickshaw Other Functions
//
//  Created by Anirudha Paul on 6/2/16.
//  Copyright © 2016 Anirudha Paul. All rights reserved.
//

#include <stdio.h>

/*
This function calculates calories burned;
 
 Function parameter 
 
 distance(double) - it is the distance walked in Kilometer
 time (double) - total amount of time walked in Hour
 weight (double) - body weight in KG ;
 
 Return Value - 
 calories burned in the process
 
 **This function thinks that Walking surface grade is 0%
 
 References -
 
 Margaria R, Cerretelli P, Aghemo P, Sassi G. Energy cost of running. J Appl Physiol. 1963 Mar;18:367-70.
 
 Margaria, R., 1938. Sulla fisiologia, e specialmente sul consumo energetico, della marcia e della corsa a varie velocita ed inclinazioni del terreno. Atti Accad. Naz. Lincei Classe Sci. Fis. Mat. Nat. Serie VI 7, 299–368.
 
 American College of Sports Medecine: ACSM's Metabolic Calculations Handbook, 2007, Baltimore, MD. Also available online at: ACSM Metabolic Equations
 
*/

double calorieBurner(double distance , double time , double weight)
{
    double caloriesBurned = 0.0 ;
    
    caloriesBurned = 0.0215 * distance * distance * distance - 0.1765 * distance * distance + 0.8710 * distance + 1.4577 * weight * time ;
    
    return caloriesBurned ;
}

/*
 This function calculates maximum of two variables
 
 Function parameter
 
 x and y are two integers
 
 reurn value - 
 maximum of x and y
 */
int max(int x , int y)
{
    if(x>y)
    { 
        return x;
    }
    else
    {
        return y;
    }
}


/*
 This function calculates fare of the rickshaw
 
 Function parameter
 
 distance(double) - it is the distance walked in Kilometer
 baseFare (int) - holds the base fare of rickshaw
 farePerUnitDistance - holds the per unit distance fare after covering the base distance
 
 Return value -
 Rickshaw fare
 
 **farePerUnitDistance is now currently a constant attribute
 **It uses a plus method
 
 References -
 
 Max Plus Methods for NonLinear Control and Estimation
 
 */

int fareCalculator(int baseFare , int farePerUnitDistance , double distance)
{
    double baseDistance = 1.0;
    double fare = baseFare + (distance - baseDistance) * farePerUnitDistance;
    
    return fare ;
}


int main(int argc, const char * argv[])
{
    int baseFare = 10 ;
    int farePerUnitDistance = 5;
    double distance = 3.4;
    double time = 1.4 ;
    double weight = 82;
    
    printf("Rickshaw fare you saved = %d\n", fareCalculator(baseFare, farePerUnitDistance, distance));
    
    printf("Calories burned = %lf\n", calorieBurner(distance, time, weight));
    return 0;
}

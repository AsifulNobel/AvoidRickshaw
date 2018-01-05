distance = 1.024;
time = ((distance/1.38582) * 1000)/3600;
steps = (distance * 1000) / 0.70104
weight = 75;
% 1.38582m/s
Calories = 0.0215 * distance^3 - 0.1765 * distance^2 + 0.871 * distance + 1.4577 * weight * time

Fare = 7.3783 + distance * 13.1041

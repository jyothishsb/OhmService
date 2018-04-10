# OhmService
ASP .NET Web API to calculate the resistance ohm value

Endpoint URI : /api/Resistor/<string: bandAColor>/<string: bandBColor>/<string: bandCColor>/<string: bandDColor>

This web api calculates and returns the ohm resistance with the 4 color bands. 
Please note the below conditions:
1. Always the upper limit of tolerance is returned.
2. The resistance value returned will always be the closest intiger.

# not-private-operators
Regular expressions and text lists to identify operators who have no ICAO operator code but are not private citizens.

**Now that VRS isn't taking PlaneBase aircraft updates it's no longer necessary to filter out private individuals, consequently
this repository is no longer being updated.**

## Virtual Radar Server's use of these files.

All aircraft that do not have an operator ICAO and are not military are assumed to be operated by private citizens unless:

1. The operator name is in ```not-private-names.txt``` or,

2. The operator name matches a regular expression in ```not-private-regular-expressions.txt``` and it is not in ```private-names.txt```.

## Editor Credits

The editor application icon was downloaded from here:

http://www.iconarchive.com/show/vintage-icons-by-designcontest/Pencil-icon.html

and was created by **DesignContest** (http://www.designcontest.com).


#!/usr/bin/env bash

SCRIPTPATH="$( cd "$(dirname "$0")" >/dev/null 2>&1 ; pwd -P )"

dirname $SCRIPTPATH
# #remove all from UML folder
# rm -r ../UML
# # Generate UML diagrams
# puml-gen /mnt/c/Users/Ryzen/Documents/working-space/nw-demos/Design-patterns/Creational/Abstract\ Factory  /mnt/c/Users/Ryzen/Documents/working-space/nw-demos/Design-patterns/Creational/Abstract\ Factory//UML  -dir -excludePaths bin,obj,Properties -createAssociation -allInOne

# # Remove all except include.puml
# cd /mnt/c/Users/Ryzen/Documents/working-space/nw-demos/Design-patterns/Creational/Abstract\ Factory//UML/
# ls | grep -v 'include.puml' | xargs rm -r

#!/bin/bash

# Get folder paths
SCRIPT_PATH="$( cd "$(dirname "$0")" >/dev/null 2>&1 ; pwd -P )"
PARENT_PATH=`dirname $SCRIPT_PATH`
UML_PATH="$PARENT_PATH/UML"
echo "SCRIPT PATH: $SCRIPT_PATH"
echo "PARENT PATH: $PARENT_PATH"
echo "UML PATH: $UML_PATH"
 
# Delete UML folder if exist
if [ -d $UML_PATH ]; 
  then rm -rf $UML_PATH;
fi

# Generate UML diagrams
puml-gen $PARENT_PATH $UML_PATH -dir -excludePaths bin,obj,Properties -createAssociation -allInOne

# Delete all diagrams in UML folder except include.puml
cd $UML_PATH 
ls | grep -v 'include.puml' | xargs rm -r

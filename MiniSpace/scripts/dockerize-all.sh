#!/bin/bash

directories=(
    "MiniSpace.APIGateway"
    "MiniSpace.Web"
    "MiniSpace.Services.Identity"
)

for dir in "${directories[@]}"; do
    echo "Processing $dir..."

    if [ -f "$dir/scripts/dockerize-tag-push.sh" ]; then
        chmod +x "$dir/scripts/dockerize-tag-push.sh"
        echo " ========================================================================================================== "
        (cd "$dir/scripts" && ./dockerize-tag-push.sh)
        echo " ========================================================================================================== "
    else
        echo "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - "
        echo "dockerize-tag-push.sh not found in $dir"
        echo "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - "
    fi
done
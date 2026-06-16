#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained from https://blog.neural4d.com/wp-content/uploads/2026/01/Neural4D-API-Documentation.pdf
install_autosdk_cli
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Neural4D \
  --clientClassName Neural4DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

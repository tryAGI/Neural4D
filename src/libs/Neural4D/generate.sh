#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://blog.neural4d.com/wp-content/uploads/2026/01/Neural4D-API-Documentation.pdf
dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Neural4D \
  --clientClassName Neural4DClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

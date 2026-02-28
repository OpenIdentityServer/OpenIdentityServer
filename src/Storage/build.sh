# SPDX-License-Identifier: Apache-2.0

#!/usr/bin/env bash
set -euo pipefail
dotnet run --project build -- "$@"
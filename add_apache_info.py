# SPDX-License-Identifier: Apache-2.0

import os

# SPDX license line to add
license_line = "# SPDX-License-Identifier: Apache-2.0"

# Root directory to start from (current folder)
root_dir = "."

for dirpath, dirnames, filenames in os.walk(root_dir):
    for filename in filenames:
        if filename.endswith(".sh"):
            file_path = os.path.join(dirpath, filename)
            
            # Read the file safely, removing any BOM if present
            with open(file_path, "r", encoding="utf-8-sig") as f:
                content = f.readlines()
            
            # Skip if SPDX line already exists (ignoring leading/trailing spaces)
            if content and license_line.strip() in content[0].strip():
                continue
            
            # Prepend SPDX line and a blank line
            new_content = [license_line + "\n", "\n"] + content
            
            # Write back without BOM
            with open(file_path, "w", encoding="utf-8") as f:
                f.writelines(new_content)
            
            print(f"Added SPDX to {file_path}")
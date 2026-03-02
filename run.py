import os

ROOT_DIR = "."  # Change this if needed

TARGET_TEXT = "SPDX-License-Identifier: Apache-2.0"


def process_file(filepath):
    try:
        with open(filepath, "r", encoding="utf-8") as f:
            lines = f.readlines()
    except (UnicodeDecodeError, PermissionError, OSError):
        # Skip binary/unreadable files
        return

    if not lines:
        return

    first_line = lines[0]

    # Check if first line CONTAINS the target text
    if TARGET_TEXT in first_line:
        remaining = lines[1:]

        # Remove whitespace-only lines until first non-whitespace line
        index = 0
        while index < len(remaining) and remaining[index].strip() == "":
            index += 1

        new_content = remaining[index:]

        with open(filepath, "w", encoding="utf-8") as f:
            f.writelines(new_content)

        print(f"Modified: {filepath}")


def walk_directory(root_dir):
    for root, dirs, files in os.walk(root_dir):
        for file in files:
            full_path = os.path.join(root, file)
            process_file(full_path)


if __name__ == "__main__":
    walk_directory(ROOT_DIR)
# Checks if there are any 'Star-OS' or 'StarOS' texts in Kyanite code, fun fact: Star-OS is old name of Kyanite

import glob
import os

KYANITE_SRC = "..\\"
PROJECT_FILES = []
SEARCH_FILES = ['*.cs', '*.py', '*.txt', '*.md']
WORDS_TO_SCAN = ['star-os', 'staros']

for x in os.walk(KYANITE_SRC):
    for extension in SEARCH_FILES:
        for y in glob.glob(os.path.join(x[0], extension)):
            PROJECT_FILES.append(y)

PROJECT_FILES.remove(f"{KYANITE_SRC}Kyanite.Scripts\\check_old_labels.py")

for file in PROJECT_FILES:
    for word in WORDS_TO_SCAN:
        with open(file, "r") as proj_file:
            if word in proj_file.read().lower():
                print(f'Unexpected identifier in: {file}')

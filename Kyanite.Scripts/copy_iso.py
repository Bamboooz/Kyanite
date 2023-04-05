# copies Kyanite .iso file from bin to project folder

import shutil
import os

ISO_FILE = "../bin/Debug/net6.0/Kyanite.iso"
BUILD_DIR = "../Kyanite.build"

if os.path.isfile(ISO_FILE):
    os.remove(ISO_FILE)

shutil.copy(ISO_FILE, BUILD_DIR)

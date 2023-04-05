# copies Kyanite .iso file from bin to project folder

import shutil
import os

ISO_FILE = "../bin/Debug/net6.0/Kyanite.iso"
BUILD_DIR = "../Kyanite.Build"

if os.path.isfile(BUILD_DIR + "//Kyanite.iso"):
    os.remove(BUILD_DIR + "//Kyanite.iso")

shutil.copy(ISO_FILE, BUILD_DIR)

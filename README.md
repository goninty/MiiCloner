# Mii Cloner

This tool lets you clone Mii characters that you've extracted from your Wii's Mii Channel.

### How to extract Mii files from your Wii
You can use either [Mii Extractor](https://wii.brewology.com/downloads/download.php?id=2640) or [SaveGame Manager GX](https://wiibrew.org/wiki/SaveGame_Manager_GX) to copy Miis onto your SD card. Mii Extractor saves your Miis with a `.mii` extension, while SaveGame Manager saves them with a `.miigx` extension. Mii Cloner accepts both of these file types.

### Cloning your Mii
Upon opening Mii Cloner, you can load one of three file types: `.mii`, `.miigx` and `.mae`. `.mae` files are Miis that have been saved using the [RiiConnect24 Mii Editor](https://rc24.xyz/goodies/mii/). These three file types are all exactly the same on the inside.

Once loaded, you can edit a Mii's:
* Name
* Creator name
* Gender
* Favorite color
* Favorite status
* Birthday

The Mii and creator names are displayed using the [CTMKF](http://wiki.tockdom.com/wiki/CTMKF) font, if it's installed on your system. This means that any special MKWii symbols in your name will appear.

Once you're ready to clone your Mii, you can hit the `Export Clone` button.

### Using the Mogi Mii cloner feature
If you'd like to clone one Mii into 26 alphabetically tagged Miis for use in MKWii's Mogi Lounge, then you can use this feature. Simply load in a Mii, make any edits you'd like, and hit the `Generate 26 Miis with A-Z tags for Mogi Lounge` button.

Note that this feature simply adds a single letter in front of your Mii's name - so `Player` becomes `A Player` and so on. Due to this, if your Mii's name is longer than 8 characters, you'll need to shorten it before you can use this feature.

After choosing a folder to place the clones, be sure to select the correct file type - `.mii` or `.miigx` based on the app you'll be using to install the clones. This is explained a bit more below. Click through the confirmation alert (just, please, make sure you don't accidentally add 26 files to somewhere you don't want them) and your tagged clones will be generated.

### Adding Mii files back to your Mii Channel
Either [Mii Installer](https://www.brewology.com/downloads/download.php?id=2641) or [SaveGame Manager GX](https://wiibrew.org/wiki/SaveGame_Manager_GX) can be used to add your cloned Miis back to your Mii Channel.

Mii Installer doesn't seem to care what file type your Miis take - as long as they're in the correct directory on the SD card, then it will (attempt) to install them to your Mii Channel. As such, I'd be careful against adding any files to the `miis` folder on your SD card that aren't Mii files (`.mii`, `.miigx` or `.mae`).

SaveGame Manager GX however will only allow you to install `.miigx` files. As such, **if you are using SaveGame Manager GX be sure to save your cloned Miis as `.miigx` files**.

Once you've cloned the Miis using Mii Cloner, whack them onto your SD card in the correct place and use the HBC app of your choice to install them. 

### Bug Reports / Feature Requests
If you come across any bugs (there probably are a few), or would like any extra features added, please either open an issue here on GitHub or contact me on Discord at `Ninty#7513`.
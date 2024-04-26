import fs from 'fs-extra';

const inputBuild = './dist';
const outputBaseFolderNative = '../../App';
const outputBuild = outputBaseFolderNative;

async function createPackage() {
  try {
    // Clean up
    await fs.remove(outputBaseFolderNative);

    // Copy build files
    await fs.copy(inputBuild, outputBuild);

    // Done
    console.log(`Web package successfully created in ${outputBaseFolderNative}`);
  } catch (error) {
    console.error('Error creating package:', error);
  }
}

createPackage();

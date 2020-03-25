#!/usr/bin/python

# Import the needed packages
import numpy as np
import keras
from sklearn.datasets import load_files       
from keras.utils import np_utils
import numpy as np
from glob import glob

# The ResNet50 model
import PIL  
from PIL import ImageFile  
from keras.applications.resnet50 import ResNet50
from keras.layers import Conv2D, MaxPooling2D, GlobalAveragePooling2D
from keras.layers import Dropout, Flatten, Dense
from keras.models import Sequential
from keras.applications.resnet50 import preprocess_input, decode_predictions

# Used methods
from keras.preprocessing import image                  
from tqdm import tqdm

# Make an interprocess communication between C# and the Python script
import sys 
stringPath = sys.argv[1]

# Import the dog breeds names from the file that contains those names
# These are the labels of the model
file_dogNames = open(r"D:\Atestat-DogTopia\DogTopia\DogTopia\Resources\dogNames.txt")
dog_names = []
for dog in file_dogNames:
    dog_names.append(dog)
dog_names = [dog.replace('\n', '') for dog in dog_names]

# The structure of the neural network
ResNet50_model = Sequential()
ResNet50_model.add(GlobalAveragePooling2D(input_shape=(1, 1, 2048)))
ResNet50_model.add(Dense(133, activation='softmax'))

# Add the learned parameters
ResNet50_model.load_weights('D:\Atestat-DogTopia\DogTopia\DogTopia\Resources\weights.best.ResNet50.hdf5')

'''
	Function that takes as input a string representing the path to the image.
        Return a 4D tensor, that represents the image on 224*224 pixels, 3 chanels (RBG)
'''
def path_to_tensor(img_path):
    # Load the image from the img_path
    img = image.load_img(img_path, target_size=(224, 224))
    # Convert the imagine to a 3D tensor of size (224, 244, 3)
    x = image.img_to_array(img)
    # Convert the 3D tensor to a 4D tensor of size (1, 224, 224, 3) and return it
    return np.expand_dims(x, axis=0)

'''
	Function that takes as input a list of string each representing the path to an image.
	Return a list of 4D tensors (one tensor for each image)
'''
def paths_to_tensor(img_paths):
    list_of_tensors = [path_to_tensor(img_path) for img_path in tqdm(img_paths)]
    return np.vstack(list_of_tensors)

# Return the name of the predicted dog breed
def ResNet50_predict_labels(img_path):
    # Returns prediction vector for image located at img_path
    img = preprocess_input(path_to_tensor(img_path))
    return np.argmax(ResNet50_model.predict(img))

def extract_Resnet50(tensor):
	from keras.applications.resnet50 import ResNet50, preprocess_input
	return ResNet50(weights='imagenet', include_top=False, pooling="avg").predict(preprocess_input(tensor))

'''
	Function that takes as input a string representing the path to the image.
	Return the predicted dog breed
'''
def ResNet50_predict_breed(img_path):
    # Extract the bottlenecks features from the ResNet50 model
    bottleneck_feature = extract_Resnet50(path_to_tensor(img_path))
    # Make sure the dimensions are correct
    bottleneck_feature = np.expand_dims(bottleneck_feature, axis=0)
    bottleneck_feature = np.expand_dims(bottleneck_feature, axis=0)
    # Get the probability vector
    predicted_vector = ResNet50_model.predict(bottleneck_feature)
    # Return the predicted dog breed
    return dog_names[np.argmax(predicted_vector)]

print(ResNet50_predict_breed(stringPath))

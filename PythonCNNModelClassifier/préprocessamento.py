import cv2
import os
import numpy as np
import tensorflow as tf


# # Sample
# img_array = cv2.imread("dataset/Train/with_mask/4.png")
# plt.imshow(img_array)
# plt.show()


# Preprocessing ###########################################################################
data_path = 'dataset/'
classes = os.listdir(data_path)
labels = [i for i in range(len(classes))]
labels_dict = dict(zip(classes, labels))

print(str(labels) + "\n" + str(classes) + "\n" + str(labels_dict))

# Converter todas as imagens para RBG e para um Array
img_size = 256
X = []
y = []

for classe in classes:
    folder_path = os.path.join(data_path, classe)
    img_names = os.listdir(folder_path)

    for img_name in img_names:
        img_path = os.path.join(folder_path, img_name)
        img = cv2.imread(img_path)

        try:
            gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
            resized = cv2.resize(gray, (img_size, img_size))
            X.append(resized)
            y.append(labels_dict[classe])
        except Exception as e:
            print('Exception: ', e)

print("The 'for' is Done")

# Normalizar os dados ###########################################################################
# Codigo que encontrei na net ( X = X/255.0; ) https://www.youtube.com/watch?v=d3DJqucOq4g min:7
X = np.array(X)/255.0
X = np.reshape(X, (X.shape[0], img_size, img_size, 1))
y = np.array(y)

# One-hot encoding
y = tf.keras.utils.to_categorical(y)

# Guardar os arrays
print(np.shape(X))
print(np.shape(y))
np.save('Data', X)
np.save('Targets', y)

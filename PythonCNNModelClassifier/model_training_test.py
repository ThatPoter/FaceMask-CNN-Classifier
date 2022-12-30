import numpy as np
from sklearn.model_selection import train_test_split
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Conv2D, MaxPool2D, Dropout, Flatten, Dense
from tensorflow.keras.callbacks import EarlyStopping, ModelCheckpoint, TensorBoard
import matplotlib.pyplot as plt

# Inicializar
X = np.load('Data.npy')
print("Data Load: Done")
y = np.load('Targets.npy')
print("Targets Load: Done")
print("Loading Process: Done")
np.random.seed(123)
# Train Test Split
train_X, test_X, train_y, test_y = train_test_split(X, y, test_size=0.4)
model = Sequential()
# Input
model.add(Conv2D(50, kernel_size=3, activation='relu', input_shape=(256, 256, 1), padding='same'))
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation='relu'))
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation='relu'))
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation='relu'))
model.add(MaxPool2D(2))
model.add(Flatten())
model.add(Dropout(0.25))
model.add(Dense(25, activation='relu'))
model.add(Dense(2, activation='sigmoid'))
model.summary()

# Compile the model
print("COMPILING THE MODEL")
model.compile(optimizer='adam', loss='binary_crossentropy', metrics=['accuracy'])

# Fitting the model
print("FITTING THE MODEL")
checkpoint = ModelCheckpoint('CheckPoint/', monitor='val_loss', save_best_only=True, save_freq='epoch')
checkpoint_list = [checkpoint]
training = model.fit(train_X, train_y, epochs=9, validation_split=0.3, batch_size=32, callbacks=[checkpoint_list])
# EarlyStopping(patience=2)

# Evaluate
model.evaluate(test_X, test_y, batch_size=5)

# Guardar o modelo
model.save('Modelo/')
model.save_weights('ModelWeights/')

# Plot loss function and see if the model is overfiting
history = training.history
plt.plot(history['loss'], 'r', label='Train Loss')
plt.plot(history['val_loss'], label='Val Loss')
plt.title('Model Loss')
plt.xlabel('Epochs')
plt.ylabel('Loss')
plt.legend()
plt.show()

# Plot accuracy function and see if the model is overfiting
history = training.history
plt.plot(history['accuracy'], 'r', label='Train Accuracy')
plt.plot(history['val_accuracy'], label='Val Accuracy')
plt.title('Model Accuracy')
plt.xlabel('Epochs')
plt.ylabel('Accuracy')
plt.legend()
plt.show()

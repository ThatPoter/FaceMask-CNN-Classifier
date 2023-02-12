import numpy as np
from sklearn.model_selection import train_test_split
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Conv2D, MaxPool2D, Dropout, Flatten, Dense
import tensorflow as tf
from tensorflow.keras.callbacks import EarlyStopping, ModelCheckpoint
import matplotlib.pyplot as plt


# To see if you have any active GPUs accessible to tensorflow
if tf.test.gpu_device_name():
    print("Default GPU Device: {}".format(tf.test.gpu_device_name()))
else:
    print("Please install GPU version of TF")


# Limit GPU memory usage with memory_limit
gpus = tf.config.experimental.list_physical_devices("GPU")
if gpus:
    try:
        tf.config.experimental.set_virtual_device_configuration(
            gpus[0],
            [tf.config.experimental.VirtualDeviceConfiguration(memory_limit=9216)],
        )
    except RuntimeError as e:
        print(e)


# Loading data to initialize the train
X = np.load("Data(10K,128p).npy")
print("Data Load: ", X.dtype)
y = np.load("Targets(10K,128p).npy")
print("Targets Load: ", y.dtype)
print("Loading Process: Done")
np.random.seed(123)


# Train Test Split
train_X, test_X, train_y, test_y = train_test_split(X, y, test_size=0.4)
model = Sequential()

# Model architecture
model.add(
    Conv2D(
        50, kernel_size=3, activation="relu", input_shape=(128, 128, 1), padding="same"
    )
)
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation="relu"))
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation="relu"))
model.add(MaxPool2D(2))
model.add(Conv2D(50, kernel_size=3, activation="relu"))
model.add(MaxPool2D(2))
model.add(Flatten())
model.add(Dropout(0.25))
model.add(Dense(25, activation="relu"))
model.add(Dense(2, activation="sigmoid"))
model.summary()


# Model checkpoint
checkpoint = ModelCheckpoint(
    "CheckPoint/best-epoch.hdf5",
    monitor="val_loss",
    save_best_only=True,
    save_freq="epoch",
    verbose=1,
)
# Model early stopping
early_stop = EarlyStopping(
    monitor="val_loss",
    patience=2,
    verbose=1,
)
checkpoint_list = [checkpoint, early_stop]

# Compile the model
print("COMPILING THE MODEL")
model.compile(optimizer="adam", loss="binary_crossentropy", metrics=["accuracy"])

# Fitting the model
print("FITTING THE MODEL")
training = model.fit(
    train_X,
    train_y,
    epochs=20,
    validation_split=0.3,
    batch_size=16,
    callbacks=checkpoint_list,
)

# Evaluate
model.evaluate(test_X, test_y, batch_size=16)


# Save the model
model.save("Model/")

# Save the model weights
# model.save_weights("ModelWeights/")


# Plot loss function to see if the model is overfiting
history = training.history
plt.plot(history["loss"], "r", label="Train Loss")
plt.plot(history["val_loss"], label="Val Loss")
plt.title("Model Loss")
plt.xlabel("Epochs")
plt.ylabel("Loss")
plt.legend()
plt.show()

# Plot accuracy function to see if the model is overfiting
history = training.history
plt.plot(history["accuracy"], "r", label="Train Accuracy")
plt.plot(history["val_accuracy"], label="Val Accuracy")
plt.title("Model Accuracy")
plt.xlabel("Epochs")
plt.ylabel("Accuracy")
plt.legend()
plt.show()

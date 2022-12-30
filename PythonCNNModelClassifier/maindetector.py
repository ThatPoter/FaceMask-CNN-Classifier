import cv2
import numpy as np
from tensorflow.keras.models import load_model
import time

# Main code
# Load the model
model = load_model("9º Treino_Test/Modelo/")

# define the variable that will store the frames and their resolution
cap = cv2.VideoCapture(
    0,
    apiPreference=cv2.CAP_ANY,
    params=[cv2.CAP_PROP_FRAME_WIDTH, 1024, cv2.CAP_PROP_FRAME_HEIGHT, 1024],
)

# save OpenCV pre trained model for detecting faces in a variable
face_cascade = cv2.CascadeClassifier("haarcascade_frontalface_default.xml")

# create dictionaries to store labels and BGR colors
labels_dict = {0: "WithoutMask", 1: "WithMask"}
colors_dict = {0: (0, 0, 255), 1: (0, 255, 0)}

# variable to store render size and resize
img_size = 256

# while to remove the frames and produce a stream/video
while True:
    # variables to check connectivity and to save frames taken from capture
    ret, frame = cap.read()
    # convert from BGR to a GrayScale
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    # define parameters for the face detector
    faces = face_cascade.detectMultiScale(gray, 1.1, 3)

    # for which we will analyze our area of interest (square around the face)
    for (x, y, w, h) in faces:
        roi_gray = gray[y : y + w, x : x + w]
        # normalize the data
        resized = cv2.resize(roi_gray, (img_size, img_size))
        normalizedata = resized / 255.0
        # resize array to model input format
        np.shape(normalizedata)
        data_array = np.reshape(normalizedata, (1, img_size, img_size, 1))
        # sort the image with model predictions
        output = model.predict(data_array)
        # extract which of the outputs will have the highest probability, according to the model
        label = np.argmax(output, axis=1)[0]

        # define sizes colors and positions for squares and labels
        cv2.rectangle(frame, (x, y), (x + w, y + h), colors_dict[label], 2)
        cv2.rectangle(frame, (x, y), (x + w, y), colors_dict[label], -1)
        cv2.putText(
            frame,
            labels_dict[label],
            (x, y - 10),
            cv2.FONT_HERSHEY_SIMPLEX,
            1,
            (255, 255, 255),
            5,
        )

        # if you are detecting someone without a mask
        if np.argmax(output, axis=1)[0] == 0:
            # capture a frame and save it in a folder
            img_name = "imageoutput/opencv_frame_0.png"
            cv2.imwrite(img_name, frame)
            # writes to a txt file with a string waiting to be read by C# code
            fileout = open("outputswitch.txt", "w")
            fileout.write("sem")
            fileout.close()
            # time.sleep(0.1)

        # if you are detecting someone with a mask
        if np.argmax(output, axis=1)[0] == 1:
            # writes to a txt file with a string waiting to be read by C# code
            fileout = open("outputswitch.txt", "w")
            fileout.write("com")
            fileout.close()

    # opens a window and shows the stream/video
    cv2.imshow("Streaming", frame)
    # this if is to stop the while loop with the letter s
    if cv2.waitKey(1) == ord("s"):
        break

cap.release()
cv2.destroyAllWindows()

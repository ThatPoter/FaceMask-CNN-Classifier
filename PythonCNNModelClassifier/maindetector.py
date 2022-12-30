import cv2
import numpy as np
from tensorflow.keras.models import load_model
import time

# Main code
# carregar o modelo
model = load_model('9º Treino_Test/Modelo/')
# definir a variavel que vai guardar os frams e a resolução dos mesmos
cap = cv2.VideoCapture(0, apiPreference=cv2.CAP_ANY, params=[
    cv2.CAP_PROP_FRAME_WIDTH, 1024,
    cv2.CAP_PROP_FRAME_HEIGHT, 1024])
# guardar o modelo do OpenCV para detetar caras numa variavel
face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
# criar os dicionarios para guardar as labels e as cores BGR
labels_dict = {0: 'WithoutMask', 1: 'WithMask'}
colors_dict = {0: (0, 0, 255), 1: (0, 255, 0)}
# variavel para guardar o tamanho de renderização e resize
img_size = 256

# while para retirar os frames e produzir uma stream/video
while True:
    # variaveis para verificar a conectividade e para guardar os frames retirados da captura
    ret, frame = cap.read()
    # converter de BGR para GrayScale
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    # defenir parametros para o detetor de faces
    faces = face_cascade.detectMultiScale(gray, 1.1, 3)

    # for que vai analisar a nossa area de interesse (quadrado a volta da cara)
    for (x, y, w, h) in faces:
        roi_gray = gray[y:y + w, x:x + w]
        # normalizar os dados
        resized = cv2.resize(roi_gray, (img_size, img_size))
        normalizedata = resized/255.0
        # redimensionar o array para o formato de entrada do modelo
        np.shape(normalizedata)
        data_array = np.reshape(normalizedata, (1, img_size, img_size, 1))
        # classificar a imagem com as previsões do modelo
        output = model.predict(data_array)
        # extrair qual dos outputs tera maior probabilidade, segundo o modelo
        label = np.argmax(output, axis=1)[0]

        # defenir tamanhos cores e posições para os quadrados e as labels
        cv2.rectangle(frame, (x, y), (x+w, y+h), colors_dict[label], 2)
        cv2.rectangle(frame, (x, y), (x+w, y), colors_dict[label], -1)
        cv2.putText(frame, labels_dict[label], (x, y-10), cv2.FONT_HERSHEY_SIMPLEX, 1, (255, 255, 255), 5)

        # se estiver a detetar alguem sem mascara
        if np.argmax(output, axis=1)[0] == 0:
            # captura um frame e guarda numa pasta
            img_name = "imageoutput/opencv_frame_0.png"
            cv2.imwrite(img_name, frame)
            # escreve num ficheiro txt uma string a espera de ser lida pelo C#
            fileout = open('outputswitch.txt', 'w')
            fileout.write('sem')
            fileout.close()
            # time.sleep(0.1)
        # se estiver a detetar alguem com mascara
        if np.argmax(output, axis=1)[0] == 1:
            # escreve num ficheiro txt uma string a espera de ser lida pelo C#
            fileout = open('outputswitch.txt', 'w')
            fileout.write('com')
            fileout.close()

    # abre uma janela e mostra os frames
    cv2.imshow('Streaming', frame)
    # if é para parar mos o while loop com a letra s
    if cv2.waitKey(1) == ord('s'):
        break

cap.release()
cv2.destroyAllWindows()

"""
Directories (create with mkdir)
- fer2013
    - Training
        - neutral
        - sadness
        - ...
    - Test
        - neutral
        - sadness
        - ...
"""
#%%
from PIL import Image
import pandas as pd
import numpy as np
import json
from tqdm import tqdm
import matplotlib.pyplot as plt

# %%
newdf = pd.read_csv("./fer2013new.csv")
olddf = pd.read_csv("./fer2013.csv")
# %%
newdf.head(1)
#%%
olddf.head(1)
#%%
def returncolname(row, colnames):
    return colnames[np.argmax(row.values[2::])+2]

newdf['colmax'] = newdf.apply(lambda x: returncolname(x, newdf.columns), axis=1)
# %%
olddf["new_label"] = newdf["colmax"]
olddf["image_name"] = newdf["Image name"]
#%%
olddf.head(1)
#%%
olddf["new_label"].unique()
olddf["Usage"].unique()
#%%
# for row in tqdm(olddf.iterrows()):
#     im = row[1][1]
#     im_n = im.split(" ")
#     im_n = np.array(im_n, 'int8')
#     im_n = im_n.reshape(48,48)

#     im_n = Image.fromarray(np.uint8(im_n)).convert('RGB')
#     label = row[1][-2]
#     typed = row[1][2]
#     im_name = row[1][-1]

#     path = "./fer2013/"
#     if typed in ["PublicTest", "PrivateTest"]:
#         path += "test/"
#     else:
#         path += "train/"

#     if label in ['neutral', 'sadness', 'happiness', 'surprise', 'anger','fear', 'contempt', 'disgust']:
#         path += f"{label}/{im_name}"
#         # print(path)
#         im_n.save(path)
#     else:
#         pass

# # %%
import glob
import os
import json
# %%
all_images = glob.glob("fer2013/*/*/*.png",)
# %%
emotions = {x:[] for x in os.listdir("./fer2013/train")}
# %%
emotions

# %%
for i in emotions:
    emotions[i] = glob.glob(f"fer2013/train/{i}/*.png")
    emotions[i] = ["web/"+x for x in emotions[i]]
#%%
emotions[i]
# %%
with open("fer2013.js", "w+") as fp:
    json.dump(emotions, fp , indent=4)
# %%

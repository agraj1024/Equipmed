# neural collaborative filtering
# code to train and store the model to external file
# Use a medical device rating data to train the model and save it
# Then use the saved model to give recommendations
import numpy as np
import pandas as pd
from sklearn.model_selection import train_test_split
from tensorflow.keras.layers import Input, Embedding, Flatten, Concatenate, Dense, Dropout
from tensorflow.keras.models import Model
from tensorflow.keras.optimizers import Adam
ratings_data = pd.read_csv('data.csv') 
ratings_data.columns = ['user_id', 'item_id', 'rating', 'timestamp']
user_ids = ratings_data['user_id'].unique()
item_ids = ratings_data['item_id'].unique()
user_id_to_index = {user_id: idx for idx, user_id in enumerate(user_ids)}
item_id_to_index = {item_id: idx for idx, item_id in enumerate(item_ids)}
ratings_data['user_index'] = ratings_data['user_id'].map(user_id_to_index)
ratings_data['item_index'] = ratings_data['item_id'].map(item_id_to_index)
train_data, val_data = train_test_split(ratings_data, test_size=0.2, random_state=42)
embedding_size = 50
user_input = Input(shape=(1,))
user_embedding = Embedding(len(user_ids), embedding_size)(user_input)
user_embedding = Flatten()(user_embedding)
item_input = Input(shape=(1,))
item_embedding = Embedding(len(item_ids), embedding_size)(item_input)
item_embedding = Flatten()(item_embedding)
concatenated = Concatenate()([user_embedding, item_embedding])
fc1 = Dense(128, activation='relu')(concatenated)
fc1 = Dropout(0.5)(fc1)
output = Dense(1, activation='sigmoid')(fc1)
model = Model(inputs=[user_input, item_input], outputs=output)
model.compile(loss='binary_crossentropy', optimizer=Adam(lr=0.001))
model.fit([train_data['user_index'], train_data['item_index']], train_data['rating'], batch_size=64, epochs=5, validation_data=([val_data['user_index'], val_data['item_index']], val_data['rating']))
model.save('ncf_recommendation_model.h5')

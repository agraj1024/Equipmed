# neural collaborative filtering
# code to use the model stored earlier and recommend items to users given their user ID
import numpy as np
import pandas as pd
from tensorflow.keras.models import load_model
model = load_model('ncf_recommendation_model.h5')
def get_recommendations(user_id, top_n=10):
    user_index = user_id_to_index[user_id]
    all_item_indices = np.array(list(item_id_to_index.values()))
    user_input = np.array([user_index] * len(all_item_indices))
    item_input = all_item_indices
    ratings_pred = model.predict([user_input, item_input]).flatten()
    item_indices_sorted = np.argsort(ratings_pred)[::-1]
    top_item_indices = item_indices_sorted[:top_n]
    top_item_ids = [item_ids[idx] for idx in top_item_indices]
    return top_item_ids
user_id = 1
recommendations = get_recommendations(user_id)
print("Recommendations for User", user_id, ":")
for idx, item_id in enumerate(recommendations, 1): print(f"{idx}. Item ID: {item_id}")
const axios = require("axios").default;

export function loadHorses(context) {
  const headers = {
    "Content-Type": "application/json",
    Authorization: `Bearer ${localStorage.getItem("token")}`
  };

  axios
    .get("https://studlyprod.wendelbodev.dk/api/Horses", { headers: headers })
    .then(function(response) {
      // handle success
      // console.log(response);
      context.commit("loadHorses", response.data);
    })
    .catch(function(error) {
      // handle error
      console.log(error);
    })
    .then(function() {
      // always executed
    });
}

export function addHorse(context, horse) {
  const headers = {
    "Content-Type": "application/json",
    Authorization: `Bearer ${localStorage.getItem("token")}`
  };

  axios
    .post(
      "https://studlyprod.wendelbodev.dk/api/Horses",
      { headers: headers },
      {
        ID: horse.id,
        Name: horse.name,
        From: horse.from,
        Stable: horse.stable,
        Gender: horse.gender
      }
    )
    .then(function(response) {
      context.commit("addHorse", response.data);
    })
    .catch(function(error) {
      console.log(error);
    });
}

export function deleteHorse(context, id) {
  const headers = {
    "Content-Type": "application/json",
    Authorization: `Bearer ${localStorage.getItem("token")}`
  };

  axios
    .delete(`https://studlyprod.wendelbodev.dk/api/Horses/${id}`, {
      headers: headers
    })
    .then(function(response) {
      // handle success
      console.log(response);
      context.commit("deleteHorse", id);
    })
    .catch(function(error) {
      // handle error
      console.log(error);
    })
    .then(function() {
      // always executed
    });
}

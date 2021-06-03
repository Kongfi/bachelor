const axios = require("axios").default;

export function loginUser(context, user) {
  let router = user.router;
  axios
    .post("https://studlyprod.wendelbodev.dk/api/Users/login", {
      email: user.email,
      password: user.password
    })
    .then(function(response) {
      localStorage.setItem("token", response.data.token);
      router.push("form");
    })
    .catch(function(error) {
      let errorCode = error.response.data.errorCode;
      if (errorCode == 110101) {
        context.commit(
          "loginError",
          "Den indtastede email er ikke oprettet som bruger."
        );
      } else if (errorCode == 110103) {
        context.commit("loginError", "Adgangskoden er forkert.");
      }
      console.log(error.response.data);
    });
}

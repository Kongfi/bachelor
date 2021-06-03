<template>
  <q-page>
    <div class="flex fit row col-12 justify-center content-center">
      <div class="flex row col-12 justify-center">
        <q-icon name="img:images/logo-new.svg" class="img"></q-icon>
      </div>

      <div
        class="row col-12 col-md-6 flex justify-center q-gutter-x-col-sm q-gutter-y-sm"
      >
        <q-form
          @submit="loginSubmit"
          class="row col-12 flex justify-center q-gutter-sm"
        >
          <q-input
            class="col-10"
            bg-color="white"
            outlined
            type="email"
            v-model="email"
            label="Email"
          />
          <q-input
            class="col-10"
            bg-color="white"
            outlined
            type="password"
            v-model="password"
            label="Kodeord"
          />
          <q-btn
            class="col-10"
            color="primary"
            label="Opret ny bruger"
            unelevated
          />
          <q-btn
            class="col-10"
            color="primary"
            label="Log ind"
            type="submit"
            unelevated
          />
        </q-form>
      </div>
    </div>

    <q-dialog v-model="alert">
      <q-card>
        <q-card-section>
          <div class="text-h6">Alert</div>
        </q-card-section>

        <q-card-section class="q-pt-none"> {{ loginError }} </q-card-section>

        <q-card-actions align="right">
          <q-btn flat label="OK" color="primary" v-close-popup />
        </q-card-actions>
      </q-card>
    </q-dialog>
  </q-page>
</template>

<script>
export default {
  data() {
    return {
      email: "",
      password: "",
      alert: false,
      loginError: this.$store.state.userStore.loginError
    };
  },

  mounted: function() {
    if (!!localStorage.getItem("token")) {
      this.$router.push("form");
    }
  },

  methods: {
    loginSubmit() {
      this.$store.dispatch("userStore/loginUser", {
        email: this.email,
        password: this.password,
        router: this.$router
      });
    }
  }
};
</script>

<style lang="scss" scoped>
.img {
  width: 80%;
  height: auto;
  max-width: 250px;
  padding-bottom: 12px;

  @media (min-width: $breakpoint-sm-min) {
    max-width: 300px;
    padding-bottom: 32px;
  }
  @media (min-width: $breakpoint-md-min) {
    max-width: 350px;
    padding-bottom: 48px;
  }
  @media (min-width: $breakpoint-lg-min) {
    max-width: 400px;
    padding-bottom: 60px;
  }
  @media (min-width: $breakpoint-xl-min) {
    max-width: 500px;
    padding-bottom: 72px;
  }
}
</style>

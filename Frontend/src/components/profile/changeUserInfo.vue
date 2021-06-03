<template>
  <div>
    <q-card>
      <h1 class="text-h6 text-center">Ret brugerinfo</h1>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        v-model="obj.firstName"
        label="Fornavn"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        v-model="obj.lastName"
        label="Efternavn"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        v-model="obj.country"
        label="Land"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        v-model="obj.address"
        label="Gade & nr"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        type="number"
        v-model="obj.zipCode"
        label="Postnummer"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        v-model="obj.city"
        label="By"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        type="number"
        v-model="obj.phone"
        label="Telefon"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-input
        class="col-12 q-mx-lg"
        outlined
        type="email"
        v-model="obj.email"
        label="Email"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>
      <q-card-actions align="center" class="q-pb-lg">
        <q-btn
          label="Ændr info"
          color="primary"
          v-close-popup
          @click="updateObj(obj)"
        />
      </q-card-actions>
    </q-card>
  </div>
</template>

<script>
export default {
  name: "ChangeUserInfo",
  props: ["obj"],

  data() {
    return {};
  },

  methods: {
    updateObj(obj) {
      this.$emit("updateInfo", obj);
    }
  }
};
</script>

<style lang="scss" scoped>
.q-card {
  width: 800px;
  max-width: 80vw;
}
</style>

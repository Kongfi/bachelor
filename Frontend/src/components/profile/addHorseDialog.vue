<template>
  <div>
    <h1 class="text-h6 text-center">Tilføj hest</h1>
    <q-form class="q-mx-lg" @submit="onSubmit">
      <q-input
        class="col-12"
        outlined
        v-model="horseData.id"
        label="Hingstens FEIF ID"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-input>

      <div class="row col-12 q-ml-none q-col-gutter-x-md">
        <q-input
          class="col-xs-12 col-md-5 q-pl-none"
          outlined
          v-model="horseData.name"
          label="Navn"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>

        <q-input
          class="newHorseFrom col-xs-12 col-md-2"
          outlined
          v-model="horseData.from"
          label="Fra"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>

        <q-input
          class="newHorseStable col-xs-12 col-md-5"
          outlined
          v-model="horseData.stable"
          label="Stald"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
      </div>

      <q-select
        class="col-12"
        outlined
        :options="gender"
        v-model="horseData.gender"
        label="Køn"
        :rules="[val => !!val || '* Påkrævet']"
      ></q-select>

      <q-input
        class="col-12"
        outlined
        v-model="horseData.birthYear"
        type="number"
        label="Fødselsår"
        :rules="[
          val => !!val || '* Påkrævet',
          val => val.length <= 4 || 'Maks 4 tal, eks. \'2003\''
        ]"
        lazy-rules
      ></q-input>

      <div class="text-center q-mb-md">
        <q-btn label="Tilføj" color="primary" type="submit" v-close-popup />
      </div>
    </q-form>
  </div>
</template>

<script>
export default {
  name: "AddHorse",

  data() {
    return {
      horseData: {
        id: null,
        name: "",
        from: "",
        stable: "",
        gender: "",
        birthYear: null
      },
      gender: ["Hingst", "Hoppe", "Vallak"]
    };
  },

  methods: {
    onSubmit() {
      this.$emit("emitHorse", { horse: this.horseData });
    }
  }
};
</script>

<style lang="scss" scoped>
.newHorseFrom {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
.newHorseStable {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
</style>

<template>
  <div>
    <div class="row">
      <div class="row col-12">
        <h1 class="text-h6 col-12 q-mt-none">Bedækningsoplysninger</h1>

        <div class="text-body1 text-weight-medium">
          Dato for ankomst*
        </div>
        <q-input
          class="col-12 q-pl-none"
          outlined
          v-model="arrivalDate"
          type="date"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>

        <div class="text-body1 text-weight-medium">
          Dato for afgang*
        </div>
        <q-input
          class="col-12 q-pl-none"
          outlined
          v-model="departDate"
          type="date"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>

        <div class="text-body1 text-weight-medium">
          Bedækningsform*
        </div>
        <q-option-group
          class="col-12"
          v-model="group"
          :options="options"
          color="primary"
        ></q-option-group>

        <div
          v-if="group == 'eggTransplant'"
          class="row col-12 q-gutter-x-sm q-mt-sm"
        >
          <q-input
            class="col-12"
            outlined
            v-model="surrogateID"
            label="Rugemor FEIF ID*"
            type="search"
            :rules="[val => !!val || '* Påkrævet']"
          >
            <template v-slot:append>
              <q-icon name="mdi-magnify" />
            </template>
          </q-input>

          <div class="text-body1 text-weight-medium">
            Dato for insemination*
          </div>

          <q-input
            class="col-12 q-pl-none"
            outlined
            v-model="inseminationDate"
            type="date"
            :rules="[val => !!val || '* Påkrævet']"
          ></q-input>
          <q-input
            class="col-12"
            outlined
            v-model="doctorName"
            label="Dyrlæge navn*"
            :rules="[val => !!val || '* Påkrævet']"
          ></q-input>
          <q-input
            class="col-12"
            outlined
            type="number"
            v-model="doctorPhone"
            label="Dyrlæge telefon nr.*"
            :rules="[val => !!val || '* Påkrævet']"
          ></q-input>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "Breeding",

  data() {
    return {
      arrivalDate: "",
      departDate: "",
      group: "",
      surrogateID: "",
      surrogateName: "",
      surrogateFrom: "",
      surrogateStable: "",
      inseminationDate: "",
      doctorName: "",
      doctorPhone: "",
      options: [
        {
          label: "Stod",
          value: "stod"
        },
        {
          label: "Håndbedækning",
          value: "handBreeding"
        },
        {
          label: "Insemination",
          value: "insemination"
        },
        {
          label: "Insemination med kølesæd",
          value: "coldSeed"
        },
        {
          label: "Insemination med frostsæd",
          value: "frozenSeed"
        },
        {
          label: "Ægtransplantation",
          value: "eggTransplant"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped>
.breedingFrom {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
.breedingStable {
  @media (max-width: $breakpoint-sm-max) {
    padding-left: 0;
    margin-top: 8px;
  }
}
</style>

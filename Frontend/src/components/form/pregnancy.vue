<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12 q-gutter-sm">
        <h1 class="text-h6 col-12 q-mt-none q-mb-sm">Drægtighed oplysninger</h1>
        <div class="text-body1 text-weight-medium">
          Dato for kontrol af drægtighed*
        </div>
        <q-input
          class="col-12 q-pl-none"
          outlined
          v-model="pregnancyDate"
          type="date"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <div class="col-12 text-body1 text-weight-medium">
          Kontrolmetode*
        </div>
        <q-option-group
          class="q-mt-none"
          v-model="group"
          :options="options"
          color="primary"
        ></q-option-group>
        <q-input
          v-if="group == 'other'"
          class="col-12 q-pl-none"
          outlined
          v-model="controlOther"
          type="textarea"
          label="Skriv anden metode her - uddyb gerne"
        ></q-input>
        <div class="col-12 text-body1 text-weight-medium">
          Hoppens drægtighed*
        </div>
        <q-option-group
          class="q-mt-none"
          v-model="pregGroup"
          :options="pregOptions"
          color="primary"
        ></q-option-group>
      </q-card-section>
    </q-card>
  </div>
</template>

<script>
export default {
  name: "Pregnancy",

  data() {
    return {
      pregnancyDate: "",
      group: "",
      controlOther: "",
      options: [
        {
          label: "Scannet",
          value: "scan"
        },
        {
          label: "Håndundersøgt",
          value: "hand"
        },
        {
          label: "Andet",
          value: "other"
        }
      ],
      pregGroup: "",
      pregOptions: [
        {
          label: "Drægtig",
          value: "pregnant"
        },
        {
          label: "Ikke drægtig",
          value: "notPregnant"
        }
      ]
    };
  }
};
</script>

<style lang="scss" scoped></style>

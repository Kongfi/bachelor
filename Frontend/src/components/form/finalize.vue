<template>
  <div>
    <q-expansion-item
      v-model="finalizeExpand"
      class="q-my-md"
      icon="mdi-checkbox-marked-outline"
      label="Er alt udfyldt korrekt?"
      header-class="bg-primary text-h6 text-white"
    >
      <q-card flat class="borderPrimary row q-mb-md">
        <q-card-section class="row col-12 q-gutter-sm">
          <div class="col-12 text-caption text-grey-7 q-mt-none">
            Jeg bekræfter, at alle ovenstående oplysninger er reelle
            oplysninger, der alle følger retningslinjerne iht. lovgivning og
            stambogsreglement. Derudover gives der samtykke til at den
            indtastede data frit kan tilgås på www.worldfengur.com, og at denne
            aktion er irreversibel.
          </div>
          <q-checkbox
            class="q-mt-none"
            :dense="$q.platform.is.mobile"
            v-model="val"
            label="Alt er udfyldt korrekt, og jeg bekræfter ovenstående.*"
          ></q-checkbox>
          <q-input
            class="col-12 q-pl-none"
            outlined
            v-model="other"
            type="textarea"
            label="Skriv eventuelle bemærkninger her"
          ></q-input>
          <p class="q-mt-sm q-mb-none col-12">
            * påkrævet
          </p>
          <div class="col text-center">
            <q-btn
              color="positive"
              :disable="!val"
              label="Indberet"
              type="submit"
              to="/success"
              @click="submitForm = !submitForm"
            />
          </div>
        </q-card-section>
      </q-card>
    </q-expansion-item>
  </div>
</template>

<script>
export default {
  name: "Finalize",

  data() {
    return {
      finalizeExpand: true,
      val: false,
      other: "",
      submitForm: false
    };
  }
};
</script>

<style lang="scss" scoped>
.borderPrimary {
  border-left: $primary 7px solid;
}
</style>

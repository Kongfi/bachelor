<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12 q-gutter-sm">
        <h1 class="text-h6 col-12 q-mt-none q-mb-xs">Bekræftelse af regler</h1>
        <div class="col-12 text-caption text-grey-7 q-mt-none">
          Jeg bekræfter, at alle ovenstående oplysninger er reelle oplysninger,
          der alle følger retningslinjerne iht. lovgivning og stambogsreglement.
          Derudover gives der samtykke til at den indtastede data frit kan
          tilgås på www.worldfengur.com, og at denne aktion er irreversibel.
        </div>
        <q-checkbox
          class="q-mt-none"
          :dense="$q.platform.is.mobile"
          v-model="val"
          label="Jeg bekræfter*"
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
            color="primary"
            :disable="!val"
            label="Indberet"
            type="submit"
            @click="submitForm = !submitForm"
          />
        </div>
      </q-card-section>
    </q-card>

    <q-dialog v-model="submitForm">
      <q-card>
        <q-card-section>
          <div class="text-h6">Opmærksom</div>
        </q-card-section>

        <q-card-section class="q-pt-none">
          Din indberetning er sendt og vil blive behandlet hurtigst muligt. Når
          indberetningen er behandlet, vil du modtage en mail med bekræftelse.
        </q-card-section>

        <q-card-actions align="right">
          <q-btn flat label="OK" color="primary" v-close-popup />
        </q-card-actions>
      </q-card>
    </q-dialog>
  </div>
</template>

<script>
export default {
  name: "Finalize",

  data() {
    return {
      val: false,
      other: "",
      submitForm: false
    };
  }
};
</script>

<style lang="scss" scoped></style>

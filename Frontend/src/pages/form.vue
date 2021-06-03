<template>
  <q-page>
    <div class="text-h5 text-center q-mt-md text-weight-medium">
      Indberet bedækning
    </div>
    <form @submit.prevent.stop="onSubmit" @reset.prevent.stop="onReset">
      <reporting></reporting>
      <stallion></stallion>
      <stallionOwner></stallionOwner>
      <mare></mare>
      <mareOwner></mareOwner>
      <breeding></breeding>
      <pregnancy></pregnancy>
      <finalize></finalize>
    </form>
  </q-page>
</template>

<script>
import Reporting from "components/Form/Reporting";
import Stallion from "components/Form/Stallion";
import StallionOwner from "components/Form/StallionOwner";
import Mare from "components/Form/Mare";
import MareOwner from "components/Form/MareOwner";
import Breeding from "components/Form/Breeding";
import Pregnancy from "components/Form/Pregnancy";
import Finalize from "components/Form/Finalize";

export default {
  name: "Index",

  components: {
    Stallion,
    StallionOwner,
    Reporting,
    Mare,
    MareOwner,
    Breeding,
    Pregnancy,
    Finalize
  },

  data() {
    return {};
  },

  methods: {
    onSubmit() {
      this.Stallion.data.stallionId.validate();

      if (this.Stallion.data.stallionId.hasError) {
        this.formHasError = true;
      } else if (this.Finalize.data.val !== true) {
        this.$q.notify({
          color: "negative",
          message: "You need to accept the license and terms first"
        });
      } else {
        this.$q.notify({
          icon: "done",
          color: "positive",
          message: "Submitted"
        });
      }
    }
  }
};
</script>

<style lang="scss" scoped></style>
